using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMainSingleton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerMonoSingleton.Instance.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
