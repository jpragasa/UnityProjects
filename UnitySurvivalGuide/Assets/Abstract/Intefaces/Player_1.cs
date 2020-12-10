using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour, IDamagable
{
    public int Health { get; set; }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
