using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorHelper
{
    public static int createdObjects = 0;

    public static void CreateObject()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        createdObjects++;
        obj.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        obj.transform.position = new Vector3(Random.Range(-10, 25), Random.Range(0, 10),0);       
        GameObject.Destroy(obj, 5f);
    }


    public static int getCreatedObjects()
    {
        return createdObjects;
    }
}
