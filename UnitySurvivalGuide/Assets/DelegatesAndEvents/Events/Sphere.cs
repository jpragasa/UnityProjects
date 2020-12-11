using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void Start()
    {
        EventsMain.onClick += Fall;
    }
    public void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnDisable()
    {
        EventsMain.onClick -= Fall;
    }
}
