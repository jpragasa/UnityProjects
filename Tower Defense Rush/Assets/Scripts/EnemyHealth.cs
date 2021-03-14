using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxhitPoints = 5;
    [Tooltip("Adds amount to maxHitPoints when enemy dies.")][SerializeField] int difficultyRamp = 1;
    int currentHitPoints = 0;

    Enemy enemy;

    void OnEnable()
    {
        currentHitPoints = maxhitPoints;
    }

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        currentHitPoints--;


        if (currentHitPoints <= 0)
        {
            gameObject.SetActive(false);
            maxhitPoints += difficultyRamp;
            enemy.RewardGold();
        }
    }
}
