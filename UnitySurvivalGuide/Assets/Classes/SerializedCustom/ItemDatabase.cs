using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public ItemClass[] items;
    // Start is called before the first frame update
    void Start()
    {
        /**
         * 
         *  sword = CreateItem("Sword", 1, "Poke Stuff");
            hammer = CreateItem("Hammer", 2, "Hit Stuff");
         * 
         * 
         */
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private ItemClass CreateItem(string name, int id, string description)
    {
        return new ItemClass(name, id, description);
    }
    */
}
