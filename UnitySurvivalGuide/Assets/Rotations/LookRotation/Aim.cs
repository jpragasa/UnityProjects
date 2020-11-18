using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    [SerializeField] private Transform _sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Formula for direction
        // Direction = destination - source
        Vector3 directionToFace = _sphere.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace, Color.cyan);
        // Access current rotation = Quaternion.lookrotation
        transform.rotation = Quaternion.LookRotation(directionToFace);
    }
}
