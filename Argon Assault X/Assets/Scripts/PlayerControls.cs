using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerControls : MonoBehaviour
{
    [SerializeField] InputAction movement;
    [SerializeField] float controlSpeed;
    [SerializeField] float xRange = 5f;
    [SerializeField] float yRange = 5f;
    [SerializeField] float positionPitchFactor = -2f;
    [SerializeField] float controlPitchFactor = -10f;
    [SerializeField] float positionYawFactor = 2f;
    [SerializeField] float controlRollFactor = -20f;
    float xThrow, yThrow;
    
    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }

    private void Update()
    {
        Movement();
        Rotation();
    }

    private void Movement()
    {
        xThrow = movement.ReadValue<Vector2>().x;
        yThrow = movement.ReadValue<Vector2>().y;

        float xOffset = xThrow * Time.deltaTime * controlSpeed;
        float rawXPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange);

        float yOffset = yThrow * Time.deltaTime * controlSpeed;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, -yRange, yRange);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);

    }

    private void Rotation()
    {
        // Y Rotation
        float pitch = transform.localPosition.y * positionPitchFactor + yThrow * controlPitchFactor;
        // X Rotation
        float yaw = transform.localPosition.x * positionYawFactor;
        // Z Rotation
        float roll = xThrow * controlRollFactor;

        // Controls local location of ship, implements Euler
        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }
}
