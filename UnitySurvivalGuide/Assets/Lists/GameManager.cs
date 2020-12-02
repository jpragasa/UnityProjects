using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
    public GameObject[] objectsToSpawn = new GameObject[10];

    private void Start()
    {
        // objectsToSpawn[0] = new GameObject();
        // enemiesToSpawn.Add()

        enemiesToSpawn[2].name = "Jon";
    }
}
