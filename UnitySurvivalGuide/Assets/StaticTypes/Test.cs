using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // private Score _score;
    // Start is called before the first frame update
    void Start()
    {
        //_score = GameObject.Find("Score Keeper").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Add 10 to score
            Score.score += 10;
            Debug.Log("Current Score: " + Score.score);
        }
    }
}
