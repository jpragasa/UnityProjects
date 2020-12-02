using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_DB : MonoBehaviour
{
    [SerializeField] private List<Item_> itemDatabase = new List<Item_>();

    public void AddItem(int itemID, MainGuy player)
    {
        // Check if item matches something in the DB
        foreach(Item_ item in itemDatabase)
        {
            if(item.id == itemID)
            {
                Debug.Log("Found the item!");
                // Check for inventory slots
                player.inventory[0] = item;
                return;
            }
        }

        Debug.Log("Cannot find item");
    }

    public void RemoveItem(int itemID, MainGuy player)
    {
        foreach(Item_ item in itemDatabase)
        {
            if(item.id == itemID)
            {
                // We have a match
                player.inventory[0] = null;
            }
        }
    }
}
