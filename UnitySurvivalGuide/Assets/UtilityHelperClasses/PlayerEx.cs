using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEx : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UtilityHelper.CreateObject();
        } 

        if(Input.GetKeyDown(KeyCode.E))
        {
            UtilityHelper.SetPositionToZero(this.gameObject);
        }
    }
}
