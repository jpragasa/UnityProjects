using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField] private float _thrustSpeed;
    [SerializeField] private float _rotationSpeed;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            // AddRelativeForce allows the object to go in the direction it is facing
            rb.AddRelativeForce(Vector3.up * _thrustSpeed * Time.deltaTime, ForceMode.Impulse);
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Rotate(Vector3.forward * _rotationSpeed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Rotate(Vector3.back * _rotationSpeed);
        }
    }
}
