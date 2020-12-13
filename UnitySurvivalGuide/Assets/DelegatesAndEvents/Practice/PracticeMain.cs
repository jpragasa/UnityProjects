using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeMain : MonoBehaviour
{
    //public Func<int, int, int> CalculateSum;
    public Action<int, int> CalculateSum;
    void Start()
    {
        // My Solution

        //CalculateSum = (num1, num2) => num1 + num2;

        //int sum = CalculateSum(3, 5);

        //Debug.Log(sum);

        CalculateSum = (a, b) => {
            var total = a + b;
            if(total < 100)
            {
                Debug.Log(total + "is less than 100");
            }
        };

        CalculateSum(5, 9);
    }
}
