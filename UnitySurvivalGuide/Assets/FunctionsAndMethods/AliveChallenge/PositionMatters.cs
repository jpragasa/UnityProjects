using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMatters : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            changePosition();
        }
    }

    private void changePosition()
    {
        transform.position = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
    }
}
