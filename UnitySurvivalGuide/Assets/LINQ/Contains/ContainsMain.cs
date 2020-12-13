using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ContainsMain : MonoBehaviour
{
    public string[] names = { "Josh", "Jackie", "Paityn", "Amber", "Enoch" };

    private void Start()
    {
        //var nameFound = names.Any((name) => name == "Josh");
        var nameFound = names.Contains("Paityn");
        Debug.Log("Name Found: " + nameFound);
    }
}
