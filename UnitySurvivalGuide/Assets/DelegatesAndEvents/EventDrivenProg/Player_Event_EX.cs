﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Event_EX : MonoBehaviour
{

    public delegate void OnDeath();
    public static event OnDeath onDeath;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Death();
        }
    }

    void Death()
    {
        if(onDeath != null)
        {
            onDeath();
        }
    }
}
