using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoLoop : MonoBehaviour
{
    int apples = 100;
    // Start is called before the first frame update
    void Start()
    {
        do
        {
            // some code
            Debug.Log(this.apples);
            apples--;
        } while (apples > 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
