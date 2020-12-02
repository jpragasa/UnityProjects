using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfNames : MonoBehaviour
{
    public List<GameObject> listOfNames;

    private void Start()
    {
        printNames();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            removeName();
            printNames();
        }
    }

    private void printNames()
    {
        foreach(GameObject obj in listOfNames)
        {
            Debug.Log(obj.name);
        }
    }

    private void removeName()
    {
        try
        {       
            listOfNames.Remove(listOfNames[UnityEngine.Random.Range(0, listOfNames.Count)]);
        } catch(ArgumentOutOfRangeException e)
        {
            Debug.Log("No More Names :(");
        }
    }
}
