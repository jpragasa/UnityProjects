using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static PlayerController _instance;
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _runSpeed;
    private float horizontalInput;
    private float verticalInput;
    private float currentSpeed;
    private float originalSpeed;
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
        originalSpeed = _speed;
    }

    private void FixedUpdate()
    {
        Controls();
    }

    private void Controls()
    {
        horizontalInput = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
        verticalInput = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            currentSpeed = _speed;
            _speed += _runSpeed;
            Mathf.Clamp(_speed, originalSpeed, originalSpeed + 5);
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            _speed -= currentSpeed;
            if(_speed < originalSpeed)
            {
                _speed = originalSpeed;
            }
        }
        transform.Translate(new Vector3(0, 0, verticalInput));
        transform.Rotate(new Vector3(0, horizontalInput, 0));
    }
}
