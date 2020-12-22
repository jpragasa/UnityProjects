using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float constraintMin;
    [SerializeField] private float constraintMax;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _clip;
    [SerializeField] private float volume = 0.5f;
    private static PlayerController _instance;
    public static PlayerController Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("PlayerController does not exist");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    private void Control()
    {
        horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;    
        transform.Translate(new Vector3(horizontalInput, 0, 0));
        transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, constraintMin, constraintMax), this.transform.position.y, this.transform.position.z);        
    }

    void Update()
    {
        Control();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject foodToThrow = FoodManager.Instance.RequestFood();
            foodToThrow.transform.position = this.transform.position;
            _audioSource.PlayOneShot(_clip, volume);
        }
    }
}
