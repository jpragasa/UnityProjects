using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{

    public int apples;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddApplesRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Create a program where we "increment" the value of how many apples we have

    IEnumerator AddApplesRoutine()
    {
        for(int i = 0; i < 100; i++)
        {
            apples++;
            yield return new WaitForSeconds(.5f);
        }
    }
}
