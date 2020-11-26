using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectParamChallenge : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ObjColorChanger(cube);
        }
    }

    private void ObjColorChanger(GameObject obj)
    {
        obj.GetComponent<MeshRenderer>().material.color = Color.cyan; 
    }
}
