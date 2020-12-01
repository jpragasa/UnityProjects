using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PropertyChallenge : MonoBehaviour
{
    private int speed;
    //private string name;

    public int Speed
    {
        get
        {
            return this.speed;
        }

        private set
        {
            this.speed = value;
        }
    }

    public string Name { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        Name = "Josh";
        speed = 200;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(string.Format("Name: {0} Speed: {1}", Name, speed));
            speed -= 1;
        }
    }
}
