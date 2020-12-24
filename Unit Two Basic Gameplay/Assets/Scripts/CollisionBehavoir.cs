using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavoir : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ground")
        {
            // Do Nothing
        }
        else if(this.gameObject.tag == "Player" && other.gameObject.tag == "Animal")
        {
            other.gameObject.SetActive(false);
            UIManager.Instance.SubtractScore(10);
        }
        else if(this.gameObject.tag == "Animal" && other.gameObject.tag == "Animal")
        {
            // Do Nothing
        }
        else
        {
             this.gameObject.SetActive(false);
             GameObject obj = other.gameObject;            
             UIManager.Instance.UpdateScore(10);           
             obj.SetActive(false);
        }
        
    }
}
