using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField] GameObject enemyContainer;
    [SerializeField] float destructionCounter;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Destruction();
    }

    private void Destruction()
    {
        foreach (Transform obj in this.transform)
        {
            GameObject fullObj = obj.gameObject;
            Destroy(fullObj, destructionCounter);
        }
    }
}
