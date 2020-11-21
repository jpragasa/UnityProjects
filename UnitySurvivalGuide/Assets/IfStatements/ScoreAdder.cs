using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAdder : MonoBehaviour
{
    [SerializeField] private Text _output;
    private int _points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _points += 10;
            _output.text = "Points: " + _points.ToString();
        }
    }
}
