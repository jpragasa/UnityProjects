using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _gravityModifier;
    [SerializeField] private bool isOnGround = true;
    public ParticleSystem explosionEffect;
    public ParticleSystem dirtParticle;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    [SerializeField] float volumeControl;
    private Rigidbody _rigidBody;
    private Animator _playerAnim;
    public bool gameOver = false;
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _playerAnim = GetComponent<Animator>();
        //_rigidBody.AddForce(Vector3.up * _jumpSpeed);
        Physics.gravity *= _gravityModifier;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            _rigidBody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            isOnGround = false;
            _playerAnim.SetBool("Grounded", false);
            _playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {       
        if(collision.gameObject.CompareTag("Ground"))
        {
            
            isOnGround = true;
            dirtParticle.Play();
            _playerAnim.SetBool("Grounded", true);
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle") && this.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            collision.gameObject.SetActive(false);
            audioSource.PlayOneShot(audioClip, volumeControl);
            _playerAnim.SetBool("Death_b", true);
            explosionEffect.Play();
            dirtParticle.Stop();
        }
    }
}
