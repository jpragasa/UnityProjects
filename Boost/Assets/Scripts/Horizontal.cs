using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal : MonoBehaviour
{
    [SerializeField] private float _horizontalMovementSpeed;
    [SerializeField] private float _waitTime = 5f;
    [SerializeField] private int _movementDistance = 10;
    private int _counter = 0;
    private bool _flag = false;
    private void Start()
    {
        StartCoroutine("HorizontalMovement");
    }

    IEnumerator HorizontalMovement()
    {
        while(true)
        {
            if (!_flag)
            {
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - _horizontalMovementSpeed,
                                                         this.gameObject.transform.position.y,
                                                         this.gameObject.transform.position.z);
                yield return new WaitForSeconds(_waitTime);
            }
            else
            {
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + _horizontalMovementSpeed,
                                                         this.gameObject.transform.position.y,
                                                         this.gameObject.transform.position.z);
                yield return new WaitForSeconds(_waitTime);
            }
            _counter++;
            if(_counter == _movementDistance)
            {
                _flag = !_flag;
                _counter = 0;
            }
            
        }
    }
}
