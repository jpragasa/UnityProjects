using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speedOffset;

    public enum Directions
    {
        FORWARD,
        LEFT,
        BACK,
        RIGHT
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Controls();
    }

    private void Controls()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Move(Directions.FORWARD);
        } 
        if(Input.GetKey(KeyCode.A))
        {
            Move(Directions.LEFT);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Directions.RIGHT);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Move(Directions.BACK);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            speedOffset += .5f;
        }
    }

    private void Move(Directions directions)
    {
        switch(directions)
        {
            case Directions.FORWARD:
                transform.Translate(Vector3.forward * speedOffset * Time.deltaTime);
                break;
            case Directions.LEFT:
                transform.Rotate(Vector3.down * speedOffset * Time.deltaTime);
                break;
            case Directions.RIGHT:
                transform.Rotate(Vector3.up * speedOffset * Time.deltaTime);
                break;
            case Directions.BACK:
                transform.Translate(Vector3.back * speedOffset * Time.deltaTime);
                break;
        }
    }
}
