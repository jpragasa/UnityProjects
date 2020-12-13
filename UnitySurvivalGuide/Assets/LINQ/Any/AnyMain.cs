using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Needed for LINQ
using System.Linq;

public class AnyMain : MonoBehaviour
{
    public string[] names = {"Joshh", "Jackie", "Paityn", "Amber", "Enoch"};

    private void Start()
    {
        // inline foreach loop
        var nameFound = names.Any(name => name == "Josh");
        Debug.Log("NameFound: " + nameFound);
    }
}
