using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private float _despawnTime;
    [SerializeField] private float _throwSpeed;
    [SerializeField] private float _rotateSpeed;
    private void OnEnable()
    {
        Invoke("Hide", _despawnTime);
    }

    void Hide()
    {
        this.gameObject.SetActive(false);
    }

    private void Update()
    {
        this.gameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + _throwSpeed);
        this.gameObject.transform.Rotate(Vector3.right, _rotateSpeed);
        this.gameObject.transform.Rotate(Vector3.down, _rotateSpeed);
    }
}
