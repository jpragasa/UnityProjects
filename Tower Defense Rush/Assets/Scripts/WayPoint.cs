using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class WayPoint : MonoBehaviour
{
    [SerializeField] Tower tower;
    [SerializeField] bool isPlaceable;
    
    public bool IsPlaceable { get { return isPlaceable; } private set { isPlaceable = value; } }

    private void OnMouseDown()
    {
        if(isPlaceable)
        {
            bool isPlaced = tower.CreateTower(tower, transform.position);            
            isPlaceable = !isPlaced;
        }        
    }
}
