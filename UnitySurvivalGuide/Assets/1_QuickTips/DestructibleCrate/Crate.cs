﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{

    [SerializeField] GameObject fracturedCrate;
    [SerializeField] GameObject explosionEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            GameObject fracturedObject = Instantiate(fracturedCrate, transform.position, Quaternion.identity);
            Rigidbody[] allRigidBodies = fracturedObject.GetComponentsInChildren<Rigidbody>();
            if(allRigidBodies.Length > 0)
            {
                foreach(var body in allRigidBodies)
                {
                    body.AddExplosionForce(500, transform.position, 10);
                }
            }
            Destroy(this.gameObject);
        }
    }
}
