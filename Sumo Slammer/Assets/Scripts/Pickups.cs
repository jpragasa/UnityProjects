using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public float boostAmount;
    public float despawnTime;

    
    private void OnEnable()
    {
        Invoke("Hide", despawnTime);
    }

    void Hide()
    {
        this.gameObject.SetActive(false);
    } 
}
