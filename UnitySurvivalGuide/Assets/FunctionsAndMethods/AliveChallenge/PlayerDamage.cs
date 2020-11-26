using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 200;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            health -= Random.Range(0, 5);
            if(isDead(health))
            {
                Debug.Log("Player is Dead");
                Destroy(this.gameObject);
            }
        }
    }

    private bool isDead(int health)
    {
        if(health <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
