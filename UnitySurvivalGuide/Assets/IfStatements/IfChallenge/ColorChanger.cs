using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private float _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            addScore();
            colorSwitch();
        }
    }

    private void addScore()
    {
        _score += 10;
    }

    private void colorSwitch()
    {
        if(_score >= 10 && _score < 50)
        {
            cube.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if(_score >= 50 && _score < 100)
        {
            cube.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if(_score >= 100 &&_score <= 200)
        {
            cube.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
