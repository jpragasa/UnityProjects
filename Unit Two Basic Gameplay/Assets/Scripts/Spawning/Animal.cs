using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private float _despawnTime;
    [SerializeField] private float _speed;
    [SerializeField] private float constraintX;
    [SerializeField] private float constraintY;
    private void OnEnable()
    {
        Invoke("Hide", _despawnTime);
    }
    private void Hide()
    {
        this.gameObject.SetActive(false);
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - .1f);
        transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, constraintX, constraintY), this.transform.position.y, this.transform.position.z);
    }
}
