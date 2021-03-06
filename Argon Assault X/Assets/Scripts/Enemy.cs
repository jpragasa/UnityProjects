using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject deathVFX;
    [SerializeField] GameObject hitVFX;    
    [SerializeField] int pointsToAdd;
    [SerializeField] int hitPoints;

    ScoreBoard scoreBoard;
    GameObject parentGameObject;
    private void Start()
    {
        SetUp();
    }

    private void SetUp()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
        parentGameObject = GameObject.FindWithTag("SpawnAtRuntime");
        AddRigidBody();
    }

    private void AddRigidBody()
    {
        Rigidbody rb = this.gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        HealthDetection();
    }   

    private void ProcessHit()
    {
        GameObject vfx = Instantiate(hitVFX, transform.position, Quaternion.identity);
        vfx.transform.parent = parentGameObject.transform;  
        scoreBoard.IncreaseScore(pointsToAdd);
        hitPoints--;
    }
    private void DestroyEnemy()
    {
        GameObject vfx = Instantiate(deathVFX, transform.position, Quaternion.identity);
        vfx.transform.parent = parentGameObject.transform;
        Destroy(this.gameObject);
    }

    private void HealthDetection()
    {
        if (hitPoints < 1)
        {
            DestroyEnemy();
        }
    }
}
