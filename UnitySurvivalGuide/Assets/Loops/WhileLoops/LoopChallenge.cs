using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopChallenge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        allNumbers();
        evenNumbers();
        oddNumbers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void allNumbers()
    {
        Debug.Log("All Numbers: ");
        for(int i = 1; i <= 10; i++)
        {
            Debug.Log(String.Format("{0}", i));
        }
    }

    private void evenNumbers()
    {
        Debug.Log("Even Numbers: ");
        int i = 10;
        do
        {
            if(i % 2 == 0)
            {
                Debug.Log(String.Format("{0}", i));
            }

            i++;
            
        } while (i <= 20);
    }

    private void oddNumbers()
    {
        Debug.Log("Odd Numbers: ");
        int i = 20;
        while(i <= 30)
        {
            
            if(i % 3 == 0)
            {
                Debug.Log(String.Format("{0}", i));
            }
            i++;
        }
    }
}
