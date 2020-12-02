using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerForChallenge : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsCreated;
    [SerializeField] private GameObject[] objectsToSpawn;
    private bool flag = false;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && objectsCreated.Count < 10)
        {
            flag = false;
          GameObject o = Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], new Vector3(Random.Range(-10, 10), Random.Range(0, 10), 0), Quaternion.identity);
          objectsCreated.Add(o);
        }
        else if(objectsCreated.Count >= 10 && flag == false)
        {
            foreach(GameObject obj in objectsCreated)
            {
                obj.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
            }
            Invoke("ClearSpawn", 2f);
            flag = true;
        }
    }

    private void ClearSpawn()
    {
        foreach(GameObject o in objectsCreated)
        {
            Destroy(o.gameObject);
        }
        objectsCreated.Clear();
    }
}
