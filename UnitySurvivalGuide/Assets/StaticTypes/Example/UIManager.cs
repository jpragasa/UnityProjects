using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Important import
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text activeEnemiesText;

    public void UpdateEnemyCount()
    {
        activeEnemiesText.text = "Active Enemies: " + SpawnManager.enemyCount;
    }
}
