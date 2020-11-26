using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamePrinter : MonoBehaviour
{

    // private string name = "Josh";

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
                if(i ==  76)
                {
                    break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
