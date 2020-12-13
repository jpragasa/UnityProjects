using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager_ : MonoBehaviour
{
    public int deathCount;
    public Text deathCountText;

    private void OnEnable()
    {
        Player_Event_EX.onDeath += UpdateDeathCount;
    }

    public void UpdateDeathCount()
    {
        deathCount++;
        deathCountText.text = "Death Count: " + deathCount;
    }
}
