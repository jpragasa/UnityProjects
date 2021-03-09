using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class WayPoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    [SerializeField] GameObject tower;
    private void OnMouseDown()
    {
        if(isPlaceable)
        {
            Instantiate(tower, this.transform.position, Quaternion.identity);
            isPlaceable = false;
        }        
    }
}
