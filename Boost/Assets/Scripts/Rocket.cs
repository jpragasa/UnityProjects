using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private AudioSource audioSource;
    [SerializeField] private float _thrustSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _respawnTime;
    [SerializeField] private float _loadWaitTime;

    enum State { Alive, Dying, Transcending};
    State state = State.Alive;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(state == State.Alive)
        {
            Thrust();
            Rotate();
        }
        
    }

    private void Rotate()
    {
        
        rb.freezeRotation = true; // take manual control of rotation
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Rotate(Vector3.back * _rotationSpeed * Time.deltaTime);
        }
        rb.freezeRotation = false;
    }

    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // AddRelativeForce allows the object to go in the direction it is facing
            rb.AddRelativeForce(Vector3.up * _thrustSpeed * Time.deltaTime);
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(audioSource.clip);
            }
        }
        else
        {
            audioSource.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(state != State.Alive)
        {
            return;
        }

        switch(collision.gameObject.tag)
        {
            case "Friendly":
                // Do Nothing
                break;
            case "Finish":
                state = State.Transcending;
                Invoke("LoadNextLevel", _loadWaitTime);
                break;
            default:
                // Death
                state = State.Dying;
                audioSource.Stop();
                StartCoroutine(FreezePosition());
                break;
        }
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
        state = State.Alive;
    }

    private void LoadFirstLevel()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator FreezePosition()
    {
        yield return new WaitForSeconds(_respawnTime);
        Invoke("LoadFirstLevel", _loadWaitTime);
        state = State.Alive;
    }
}
