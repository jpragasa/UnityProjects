using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Difficulty : MonoBehaviour
{
    private Button button;
    [SerializeField] private float delayMin;
    [SerializeField] private float delayMax;

    // Start is called before the first frame update
    void Start()
    {
        SpawnManager.Instance.DeactivateEnemies();
        button = GetComponent<Button>();
    }

    public void Easy()
    {
        
        SpawnManager.Instance.SetDelayMin(delayMin);
        SpawnManager.Instance.SetDelayMax(delayMax);
        SpawnManager.Instance.DeactivateTitleScreen();
        SpawnManager.Instance.ResetGame();
    }

    public void Medium()
    {        
        SpawnManager.Instance.SetDelayMin(delayMin);
        SpawnManager.Instance.SetDelayMax(delayMax);
        SpawnManager.Instance.DeactivateTitleScreen();
        SpawnManager.Instance.ResetGame();
    }

    public void Hard()
    {        
        SpawnManager.Instance.SetDelayMin(delayMin);
        SpawnManager.Instance.SetDelayMax(delayMax);
        SpawnManager.Instance.DeactivateTitleScreen();
        SpawnManager.Instance.ResetGame();
    }
}
