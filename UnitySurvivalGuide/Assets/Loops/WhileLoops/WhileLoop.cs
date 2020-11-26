using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoopRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When using an infinite loop, ensure you are using in conjunction with a coroutine
    IEnumerator LoopRoutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("Spawning Something");
        }
    }
}
