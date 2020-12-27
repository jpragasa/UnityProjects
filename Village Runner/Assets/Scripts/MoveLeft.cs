using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float _speed = 30;
    [SerializeField] private float _spawnTime = 2f;
    private PlayerController _playerScript;

    private void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void OnEnable()
    {
        if(this.gameObject.CompareTag("Background"))
        {
            //Do Nothing
        }
        else
        {
            Invoke("Hide", _spawnTime);
        }
        
    }

    private void Hide()
    {
        this.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(_playerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);

        }
        if(_playerScript.gameOver == true && Input.GetKeyDown(KeyCode.E))
        {
            SpawnManager.Instance.SetInActive();
            _playerScript.gameOver = false;
            Animator anim = _playerScript.GetComponent<Animator>();
            anim.SetBool("Death_b", false);
        }
    }
}
