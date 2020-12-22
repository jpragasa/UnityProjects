using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private float _despawnTime;
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
        this.gameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z -.1f);
    }
}
