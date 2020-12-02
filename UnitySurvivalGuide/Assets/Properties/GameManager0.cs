using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class GameManager0 : MonoBehaviour
{
    // Read Only Variable
    //private bool isGameOver;

    // This is an auto property
    // The downside to auto properties is that you cannot run any function code within it
    // private set allows any object in our game to READ it, but not set it, but it will allow you to set it within the class it is declared in.
    // protected set allows for the class it was declared in access to set along with any other class that derives from the class
    // Downside -- You cannot see properties within the inspector
    public bool IsGameOver { get; protected set; }
    
    // the below code is one way of using properties
    // this is better if you want to run function code
    /*
    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
        /*
        set
        {
            if(value == true)
            {
                Debug.Log("Game Over!");
            }
            isGameOver = value;
        }
        
    } */
    // Start is called before the first frame update
    void Start()
    {
        IsGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //IsGameOver = true;
            //Debug.Log(IsGameOver);
        }
    }

    public void GameOver()
    {
        IsGameOver = true;
        // Call UI Manager and enable the game over screen
    }

    
}

/**
 * When to use properties
 * - Useful for the manager classes because it will not be seen in the inspector
 * - Useful for Spawnmanagers
 * - Good for consistency
 */
