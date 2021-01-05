using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Good"))
        {
            SpawnManager.Instance.UpdateLives();
            if(SpawnManager.Instance.lives == 0)
            {
                SpawnManager.Instance.GameOver();
            }
        }
    }
}
