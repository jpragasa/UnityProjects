using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavoir : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        GameObject obj = other.gameObject;
        obj.SetActive(false);
    }
}
