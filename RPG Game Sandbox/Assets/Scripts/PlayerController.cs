using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static PlayerController _instance;
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    private float horizontalInput;
    private float verticalInput;
    public static PlayerController Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("Player Controller Does Not Exist");
            }

            return _instance;
        }
    }

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Controls();
    }

    private void Controls()
    {
        horizontalInput = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
        verticalInput = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        transform.Translate(new Vector3(0, 0, verticalInput));
        transform.Rotate(new Vector3(0, horizontalInput, 0));
    }
}
