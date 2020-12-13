using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_ : MonoBehaviour
{
    private void OnEnable()
    {
        Player_Event_EX.onDeath += ResetPlayer;
    }

    public void ResetPlayer()
    {
        Debug.Log("Resetting Player");
    }
}
