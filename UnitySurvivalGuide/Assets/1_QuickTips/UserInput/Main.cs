using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] float offset;
    void Start()
    {
        
    }

    /**
     * User Input needs to be put in the update statement
     */

    // Update is called once per frame
    void Update()
    {
        //PlayerMovement();
        //PlayerMovementExtras();
        PlayerMovementWithAxis();
    }

    public void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 1 * offset * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1 * offset * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position = new Vector3(this.transform.position.x - 1 * offset * Time.deltaTime, this.transform.position.y, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position = new Vector3(this.transform.position.x + 1 * offset * Time.deltaTime, this.transform.position.y, 0);
        }
        else if (Input.GetMouseButton(0))
        {
            if(Input.GetMouseButton(1))
            {
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1 * offset * Time.deltaTime, 0);
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x + 1 * offset * Time.deltaTime, this.transform.position.y, 0);
            }
        }
        else if (Input.GetMouseButton(1))
        {
            this.transform.position = new Vector3(this.transform.position.x - 1 * offset * Time.deltaTime, this.transform.position.y, 0);
        }
       
    }

    // Move using Translate
    public void PlayerMovementExtras()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * offset * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * offset * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * offset * Time.deltaTime);
        } 
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * offset * Time.deltaTime);
        }
    }

    // Move with Axis
    public void PlayerMovementWithAxis()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * offset * Time.deltaTime);

        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, verticalInput, 0) * offset * Time.deltaTime);
    }
}
