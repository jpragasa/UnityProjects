using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject gameObj;
    [SerializeField] private float offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            // Instantiate(gameObj, Vector3.zero, Quaternion.identity);
            Instantiate(gameObj, Vector3.zero, Quaternion.Euler(0, offset , 0));
            offset--;
        }
    }
}
