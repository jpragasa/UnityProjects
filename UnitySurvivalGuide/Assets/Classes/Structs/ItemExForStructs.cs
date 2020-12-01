using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Structs are good for nano based classes, not recommended for lots of items, but good for holding things like ammo count and such
// Struct: value type, cannot be inherited
// Classes: Reference type
public struct Item2 // Stored in the Stack
{
    public string name;
    public int itemID;
    public Item2(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}
public class ItemAddon // Stored on the Heap
{
    public string name;
    public int itemID;

    public ItemAddon(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}

public class ItemExForStructs : MonoBehaviour
{
    ItemAddon sword;

    private void Start()
    {
        sword = new ItemAddon("Sword", 1);
        int age = 25;
        //bool, bytes, char, doubles, float, int, long, structs -- Value Types
        //strings, classes, arrays, delagates -- Reference Types
        string myName = "Josh";
    }
}
/*
 * Differences between structs and classes
 * 1. Classes are stored on the Heap while structs are stored on the Stack
 * 2. Structs are value types, classes are reference types
 * 3. Structs cannot be inherited
 */