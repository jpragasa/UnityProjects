using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGuy : MonoBehaviour
{
    public Item_[] inventory = new Item_[10];
    private Item_DB _itemDatabase;
    // Start is called before the first frame update
    void Start()
    {
        _itemDatabase = GameObject.Find("ItemDB").GetComponent<Item_DB>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Request item by ID
            _itemDatabase.AddItem(0, this);
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            // Remove item by ID
            _itemDatabase.RemoveItem(0, this);
        }
    }
}
