using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeMain4 : MonoBehaviour
{
    public Func<int, int, int> Adder;

    private void Start()
    {
        Adder = (a, b) => { Debug.Log(string.Format("The sum of {0} and {1} is {2}.", a, b, a + b)); return a + b; };
        Adder(10, 50);
    }
}
