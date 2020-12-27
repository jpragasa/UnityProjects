using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _gravityModifier;
    [SerializeField] private bool isOnGround = true;    
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioClip jumpClip;
    [SerializeField] float volumeControl;
    public ParticleSystem explosionEffect;
    public ParticleSystem dirtParticle;
    private Rigidbody _rigidBody;
    private Animator _playerAnim;
    public bool gameOver;
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _playerAnim = GetComponent<Animator>();
        //_rigidBody.AddForce(Vector3.up * _jumpSpeed);
        Physics.gravity *= _gravityModifier;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && isOnGround && !gameOver)
        {
            audioSource.PlayOneShot(jumpClip, volumeControl);
            _rigidBody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            isOnGround = false;
            _playerAnim.SetBool("Grounded", false);
            _playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Clear();
            dirtParticle.Stop();
        }
    }

    public AudioSource GetAudioSource()
    {
        return audioSource;
    }

    private void OnCollisionEnter(Collision collision)
    {       
        if(collision.gameObject.CompareTag("Ground"))
        {
            dirtParticle.Clear();
            dirtParticle.Stop();
            isOnGround = true;
            _playerAnim.SetBool("Grounded", true);
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            collision.gameObject.SetActive(false);
            audioSource.PlayOneShot(audioClip, volumeControl);
            audioSource.Stop();
            _playerAnim.SetBool("Death_b", true);
            explosionEffect.Play();
            dirtParticle.Clear();
            dirtParticle.Stop();
        }
    }
}
