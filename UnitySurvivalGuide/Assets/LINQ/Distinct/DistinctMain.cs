using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DistinctMain : MonoBehaviour
{

    /// <summary>
    /// Distinct: Removes Duplicates
    /// </summary>

    public string[] names = { "Josh", "Jackie", "Paityn", "Amber", "Enoch", "Josh", "Paityn"};

    private void Start()
    {
        var uniqueNames = names.Distinct();

        foreach(var name in uniqueNames)
        {
            Debug.Log("Name: " + name);
        }
    }
}
