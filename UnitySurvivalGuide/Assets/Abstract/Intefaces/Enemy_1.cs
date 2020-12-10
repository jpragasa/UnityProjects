using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour, IDamagable
{

    public int Health { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int damageAmount)
    {
        Health -= (int)damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.cyan;
    }

}
