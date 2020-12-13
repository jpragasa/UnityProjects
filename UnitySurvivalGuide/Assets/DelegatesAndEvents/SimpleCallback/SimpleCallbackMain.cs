using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCallbackMain : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        StartCoroutine(MyRoutine(()=> { Debug.Log("The Routine Has Finished"); }));
    }

    public IEnumerator MyRoutine(Action onComplete = null)
    {
        yield return new WaitForSeconds(5.0f);
        if(onComplete != null)
        {
            onComplete();
        }
    }
}
