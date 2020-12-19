using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private void Update()
    {
        this.gameObject.transform.Rotate(Vector3.right, rotationSpeed);
    }
}
