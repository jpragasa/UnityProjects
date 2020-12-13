using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WhereMain : MonoBehaviour
{
    /// <summary>
    /// Where: sort an existing collection and returns a new collection based on a condition
    /// </summary>
    public string[] names = { "Josh", "Jackie", "Paityn", "Amber", "Enoch", "Josh", "Paityn" };
    // Start is called before the first frame update
    void Start()
    {
        var namesFound = names.Where((n) => n.Length > 5);
        foreach(var name in namesFound)
        {
            Debug.Log("Names longer than five: " + name);
        }
    }
}
