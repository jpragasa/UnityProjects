using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITEMDB : MonoBehaviour
{
    // public List<DictItemClass> itemList = new List<DictItemClass>();

    public Dictionary<int, DictItemClass> itemDictionary = new Dictionary<int, DictItemClass>();

    // Start is called before the first frame update
    void Start()
    {
        DictItemClass sword = new DictItemClass();
        sword.name = "Sword";
        sword.id = 0;

        DictItemClass bread = new DictItemClass();
        bread.name = "Bread";
        bread.id = 1;

        DictItemClass cape = new DictItemClass();
        cape.name = "Cape";
        cape.id = 2;

        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);


        // Loop with foreach
        /*foreach(KeyValuePair<int, DictItemClass> items in itemDictionary)
        {
            Debug.Log("Key: " + items.Key);
            Debug.Log("Value: " + items.Value.name);
        }*/

        // loop just the keys
        /*foreach(int key in itemDictionary.Keys)
        {
            Debug.Log("Key: " + key);
        }*/

        if(itemDictionary.ContainsKey(60))
        {
            Debug.Log("Key Found");
            var randomItem = itemDictionary[90];
        } else
        {
            Debug.Log("Key Does Not Exist");
        }

        // loop to get values
        foreach(DictItemClass item in itemDictionary.Values)
        {
            Debug.Log("Name: " + item.name + " ID: " + item.id);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
