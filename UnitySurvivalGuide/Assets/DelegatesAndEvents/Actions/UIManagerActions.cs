using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerActions : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerActionsMain.onDamageReceived += UpdateHealth;
    }
    public void UpdateHealth(int health)
    {
        // display health here
        Debug.Log("Current Health: " + health);
    }
}
