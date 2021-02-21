using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour
{

    [SerializeField] private Vector3 _movementVector = new Vector3(10f, 10f, 10f);
    //Period: the time it takes to complete one full cycle
    [SerializeField] private float period = 2f;
    private Vector3 _startingPos;
    [Range(0, 1)] [SerializeField] private float movementFactor;
    // Start is called before the first frame update
    void Start()
    {
        _startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        // Protects from period equalling zero
        if(period <= Mathf.Epsilon) { return; }

        float cycles = Time.time / period; // Grows continually from 0

        // Defining Tau
        const float tau = Mathf.PI * 2; // about 6.28
        float rawSinWave = Mathf.Sin(cycles * tau); // goes from -1 to 1

        movementFactor = rawSinWave / 2f + 0.5f;

        Vector3 offset = _movementVector * movementFactor;
        transform.position = _startingPos + offset;    
    }
}
