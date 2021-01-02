using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    [SerializeField] private float _despawnTime;
    private Rigidbody enemyRb;
    private GameObject _player;

    private void OnEnable()
    {
        Invoke("Hide", _despawnTime);
    }
    private void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        _player = GameObject.Find("Player");
    }

    private void Update()
    {
        Vector3 lookDirection = (_player.transform.position - transform.position).normalized * _speed;
        enemyRb.AddForce(lookDirection);
        OutOfBoundChecker();
    }

    private void OutOfBoundChecker()
    {
        if(this.transform.position.z > 20 || this.transform.position.z < -20 || this.transform.position.x < -20 || this.transform.position.x > 20)
        {
            Hide();
        }
    }

    private void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
