using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

// Any item of this type can be seen in the inspector
[System.Serializable]
public class ItemClass
{
    [SerializeField] private string name;
    [SerializeField] private int id;
    [SerializeField] private string description;
    [SerializeField] private Sprite icon;
    public ItemClass(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }

    public string getName()
    {
        return this.name;
    }

    public int getId()
    {
        return this.id;
    }

    public string getDescription()
    {
        return this.description;
    }

    public Sprite getIcon()
    {
        return this.icon;
    }
}
