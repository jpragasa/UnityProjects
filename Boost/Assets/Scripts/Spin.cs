using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    // Update is called once per frame
    void FixedUpdate()
    {       
       this.gameObject.transform.Rotate(new Vector3(this.transform.rotation.x - _rotationSpeed, 0, 0));
    }
}