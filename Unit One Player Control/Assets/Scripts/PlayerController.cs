using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speedOffset;
    [SerializeField] private float offsetMin;
    [SerializeField] private float offsetMax;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float waitTime;
    [SerializeField] private float routineSubtracter;
    private bool flag = false;
    public enum Directions
    {
        FORWARD,
        LEFT,
        BACK,
        RIGHT
    }
    void Start()
    {
        // horizontalInput = Input.GetAxis("Horizontal");
        // verticalInput = Input.GetAxis("Vertical");
        StartCoroutine(SlowDown(waitTime));
    }

    // Update is called once per frame
    void Update()
    {
        Controls();
    }

    private void Controls()
    {
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.Space))
        {
            speedOffset += .5f;
            Move(Directions.FORWARD);
        }
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
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Space))
        {
            speedOffset += .5f;
            Move(Directions.BACK);
        }   
        else if(Input.GetKey(KeyCode.S))
        {
            speedOffset -= .5f;
            Move(Directions.BACK);
        }

        if(speedOffset <= offsetMin)
        {
            speedOffset = 5;
        }
        else if(speedOffset >= offsetMax)
        {
            speedOffset = 100;
        }
    }

    IEnumerator SlowDown(float waitTime)
    {
        while(!flag)
        {
            speedOffset -= routineSubtracter;
            yield return new WaitForSeconds(waitTime);
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
                transform.Rotate(Vector3.down * speedOffset * Time.deltaTime, Time.deltaTime * turnSpeed);
                break;
            case Directions.RIGHT:
                transform.Rotate(Vector3.up * speedOffset * Time.deltaTime, Time.deltaTime * turnSpeed);
                break;
            case Directions.BACK:
                transform.Translate(Vector3.back * speedOffset * Time.deltaTime);
                break;
        }
    }
}
