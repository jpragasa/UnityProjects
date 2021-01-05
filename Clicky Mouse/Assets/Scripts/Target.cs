using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    [SerializeField] private float minSpeed = 12;
    [SerializeField] private float maxSpeed = 16;
    [SerializeField] private float maxTorque = 10;
    [SerializeField] private float xRange = 4;
    [SerializeField] private float ySpawnPos = -6;
    [SerializeField] private float despawnDelayX = 5f;
    [SerializeField] private float despawnDelayY = 10f;
    [SerializeField] private int targetManipValue = 0;
    [SerializeField] private ParticleSystem explosionParticle;
    private Vector3 originalVelocity;
    private Vector3 originalAngularVelocity;

    private void Awake()
    {
        originalVelocity = GetComponent<Rigidbody>().velocity;
        originalAngularVelocity = GetComponent<Rigidbody>().angularVelocity;
    }

    private void OnEnable()
    {
        this.gameObject.GetComponent<Rigidbody>().velocity = originalVelocity;
        this.gameObject.GetComponent<Rigidbody>().angularVelocity = originalAngularVelocity;
        // Get RigidBody
        targetRb = GetComponent<Rigidbody>();
        // Target is thrown upwards   
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        // Target rotates and random values
        targetRb.AddTorque(RandomTorque(),
                           RandomTorque(),
                           RandomTorque(), ForceMode.Impulse);
        // Target spawnes at a Random Location        
        transform.position = RandomSpawn();   
        Invoke("Hide", Random.Range(despawnDelayX, despawnDelayY));
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    private Vector3 RandomSpawn()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    
    private void Hide()
    {        
        this.gameObject.SetActive(false);
    }

    [SerializeField] AudioClip myClip;
    private void OnMouseDown()
    {
        SpawnManager.Instance.PlayAudioClip(myClip);
        if(this.gameObject.CompareTag("Bad"))
        {
            this.gameObject.SetActive(false);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            SpawnManager.Instance.UpdateScore(targetManipValue);
            SpawnManager.Instance.GameOver();
        }
        else
        {
            this.gameObject.SetActive(false);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            SpawnManager.Instance.UpdateScore(targetManipValue);
        }       
    }
}
