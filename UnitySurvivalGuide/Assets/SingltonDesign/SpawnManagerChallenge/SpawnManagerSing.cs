using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerSing : MonoBehaviour
{
    private static SpawnManagerSing _instance;
    public static SpawnManagerSing Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject go = new GameObject("UI Manager");
                go.AddComponent<SpawnManagerSing>();
                
                //return null;
            }          
                return _instance;           
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void StartSpawning()
    {
        Instantiate(GameObject.CreatePrimitive(PrimitiveType.Capsule), new Vector3(Random.Range(-5, 10), Random.Range(-5, 10),0), Quaternion.identity);
    }
}
/*
 * 
 * Disadvantage of Lazy Instantiation
 * - it is not going to auto populate inspector inspector
 * - Adds an extra process of prividing a dyanamic solution
 * 
 */
