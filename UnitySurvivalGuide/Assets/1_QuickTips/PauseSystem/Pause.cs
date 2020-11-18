using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    private bool flag = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This statement is to pause and unpause
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!flag)
            {
                Time.timeScale = 1;
                flag = true;
            }
            else
            {
                Time.timeScale = 0;
                flag = false;
            }
        }
        // This allows for slow motion
        if (Input.GetKeyDown(KeyCode.S))
        {
            Time.timeScale = .25f;
        }
    }
}
