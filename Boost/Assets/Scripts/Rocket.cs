using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private AudioSource audioSource;
    [SerializeField] private float _thrustSpeed;
    [SerializeField] private float _rotationSpeed;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rotate();
    }

    private void Rotate()
    {
        Thrust();
        rb.freezeRotation = true; // take manual control of rotation
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Rotate(Vector3.back * _rotationSpeed * Time.deltaTime);
        }
        rb.freezeRotation = false;
    }

    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // AddRelativeForce allows the object to go in the direction it is facing
            rb.AddRelativeForce(Vector3.up * _thrustSpeed * Time.deltaTime);
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(audioSource.clip);
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}
