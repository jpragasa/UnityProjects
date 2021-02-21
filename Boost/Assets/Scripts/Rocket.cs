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
    [SerializeField] private bool _debugMode = false;
    [SerializeField] private AudioClip[] _audioClips;
    [SerializeField] private ParticleSystem _thrustParticles;
    [SerializeField] private ParticleSystem _successParticles;
    [SerializeField] private ParticleSystem _deathParticles;
    
    

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
        // Ensures that this does not get implemented in a final build
        if(Debug.isDebugBuild)
        {
            Debuggers();
        }
        
        if (state == State.Alive)
        {
            Thrust();
            Rotate();
        }

    }

    private void Debuggers()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadNextLevel();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            _debugMode = !_debugMode;
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
            ApplyThrust();
        }
        else
        {
            audioSource.Stop();
            _thrustParticles.Stop();
        }
    }

    private void ApplyThrust()
    {
        // AddRelativeForce allows the object to go in the direction it is facing
        rb.AddRelativeForce(Vector3.up * _thrustSpeed * Time.deltaTime);
        if (!audioSource.isPlaying)
        {
            PlayAudio(0);
        }
        _thrustParticles.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(state != State.Alive || _debugMode == true)
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
                audioSource.Stop();
                _successParticles.Play();
                PlayAudio(1);              
                Invoke("LoadNextLevel", _loadWaitTime);
                break;
            default:
                // Death
                state = State.Dying;
                _deathParticles.Play();
                audioSource.Stop();
                StartCoroutine(FreezePosition());
                break;
        }
    }

    private void PlayAudio(int clipIndex)
    {
        if(!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(_audioClips[clipIndex]);
        }
        else
        {
            audioSource.Stop();
        }
    }

    private void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex + 1 > SceneManager.sceneCount)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        state = State.Alive;
    }

    private void LoadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator FreezePosition()
    {
        audioSource.Stop();
        PlayAudio(2);
        yield return new WaitForSeconds(_respawnTime);
        Invoke("LoadCurrentScene", _loadWaitTime);
        state = State.Alive;
    }
}
