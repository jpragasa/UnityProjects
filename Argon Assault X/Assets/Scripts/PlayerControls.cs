using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerControls : MonoBehaviour
{
    [Header("General Setup Settings")]
    [Tooltip("Movement Input")] [SerializeField] InputAction movement;
    [Tooltip("Shooting Input")] [SerializeField] InputAction shooting;
    
    [Header("Clamp Settings")]
    [Tooltip("X Clamp Value")] [SerializeField] float xRange = 5f;
    [Tooltip("Y Clamp Value")] [SerializeField] float yRange = 5f;

    [Header("List Of Lasers")]
    [Tooltip("List of possible lasers for player")] [SerializeField] GameObject[] lasers;

    [Header("Screen Position Based Tuning")]
    [Tooltip("(Pitch) Rotation on the Y-Axis")] [SerializeField] float positionPitchFactor = -2f;
    [Tooltip("(Yaw) Rotation on the X-Axis")] [SerializeField] float positionYawFactor = 2f;

    [Header("Player Input Based Tuning")]
    [Tooltip("Controls the amount of pitch")] [SerializeField] float controlPitchFactor = -10f;    
    [Tooltip("(Roll) Controls the amount of roll on the Z-Axis")] [SerializeField] float controlRollFactor = -20f;
    [Tooltip("How fast ship moves up and down")][SerializeField] float controlSpeed;
    float xThrow, yThrow;

    private void OnEnable()
    {
        movement.Enable();
        shooting.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
        shooting.Disable();
    }

    private void FixedUpdate()
    {
        Movement();
        Rotation();
        Fire();
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

    private void Fire()
    {
        if(shooting.ReadValue<float>() > .5f)
        {
            SetActiveLasers(true);
        }
        else
        {
            SetActiveLasers(false);
        }
    }

    private void SetActiveLasers(bool isActive)
    {
        foreach(GameObject obj in lasers)
        {
            ParticleSystem.EmissionModule particle = obj.GetComponent<ParticleSystem>().emission;
            particle.enabled = isActive;
        }
    }
}
