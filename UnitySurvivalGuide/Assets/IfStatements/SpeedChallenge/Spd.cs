using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spd : MonoBehaviour
{
    [SerializeField] private float _speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            addSpeed();
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            subtractSpeed();
        }
    }

    private void addSpeed()
    {
        _speed += 1;
        if(_speed > 20)
        {
            _speed = 20;
            Debug.Log("Slow Down!");
        }
    }

    private void subtractSpeed()
    {
        _speed -= 1;
        if(_speed < 0)
        {
            _speed = 0;
            Debug.Log("Cannot Go Below 0. Speed Up!");
        }
    }
}
