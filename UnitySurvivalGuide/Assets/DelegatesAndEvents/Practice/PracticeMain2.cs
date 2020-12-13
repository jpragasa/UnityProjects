using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeMain2 : MonoBehaviour
{
    public Action returnName;

    private void Start()
    {
        returnName = () =>
        {
            Debug.Log("The name of this object is: " + this.gameObject.name);
        };

        returnName();
    }
}
