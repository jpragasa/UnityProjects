using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This allows us to use within another class
[System.Serializable]
public class Items
{
    public int itemID;
    public string name;
    public string description;
}
public class ItemDemo : MonoBehaviour
{
    public Items[] myItems;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Items it in myItems)
        {
            Debug.Log(it.itemID + " " + it.name + " " + it.description);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int random = Random.Range(0, myItems.Length);
            Debug.Log(myItems[random].name + "," + myItems[random].itemID + ", " + myItems[random].description);
        }
    }
}
