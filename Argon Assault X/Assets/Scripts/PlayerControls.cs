using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerControls : MonoBehaviour
{
    [SerializeField] InputAction movement;
    [SerializeField] float offset;
    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        float xThrow = movement.ReadValue<Vector2>().x;
        float yThrow = movement.ReadValue<Vector2>().y;

        transform.localPosition = new Vector3(xThrow * offset * Time.deltaTime,
                                              transform.localPosition.y,
                                              transform.localPosition.z);

        transform.localPosition = new Vector3(transform.localPosition.x,
                                              yThrow * offset * Time.deltaTime,
                                              transform.localPosition.z);
    }
}
