using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody rb;
    private GameObject focalPoint;
    [SerializeField] private bool hasPowerUp = false;
    private float _currentBoost = 0;
    [SerializeField] private float _powerUpDespawnMin;
    [SerializeField] private float _powerUpDespawnMax;
    [SerializeField] private GameObject _powerUpIndicator;
    Rigidbody enemyRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal_Point");
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        rb.AddForce(focalPoint.transform.forward * _speed * verticalInput);
        _powerUpIndicator.transform.position = this.transform.position + new Vector3(0, -.5f, 0);
        if (this.transform.position.z > 15 || this.transform.position.z < -15 || this.transform.position.x < -15 || this.transform.position.x > 15)
        {
            this.gameObject.SetActive(false);
            _powerUpIndicator.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Powerup"))
        {
            hasPowerUp = true;
            _powerUpIndicator.SetActive(true);
            other.gameObject.SetActive(false);
            Pickups pickup = other.gameObject.GetComponent<Pickups>();
            StartCoroutine(PowerUp(pickup));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            enemyRigidBody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            enemyRigidBody.AddForce(awayFromPlayer * _currentBoost, ForceMode.Impulse);
        }
    }

    IEnumerator PowerUp(Pickups pickup)
    {
        _currentBoost += pickup.boostAmount;
        yield return new WaitForSeconds(pickup.despawnTime);
        _currentBoost = 0;
        hasPowerUp = false;
        _powerUpIndicator.SetActive(false);
    }
}
