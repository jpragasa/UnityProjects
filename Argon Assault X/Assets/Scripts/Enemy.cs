using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject deathVFX;
    [SerializeField] Transform parent;
    [SerializeField] int pointsToAdd;

    ScoreBoard scoreBoard;

    private void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        DestroyEnemy();
    }
    private void ProcessHit()
    {
        scoreBoard.IncreaseScore(pointsToAdd);
    }
    private void DestroyEnemy()
    {
        GameObject vfx = Instantiate(deathVFX, transform.position, Quaternion.identity);
        vfx.transform.parent = parent;
        Destroy(this.gameObject);
    }

    
}
