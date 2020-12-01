using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This is a utility class solely for immediate use for the project
 * Things to know:
 * - Cannot inherit
 * - All members must be static
 */
public static class UtilityHelper
{
    public static int myAge;
    public static void CreateObject()
    {
        // Create a new primitive cube
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public static void SetPositionToZero(GameObject obj)
    {
        // Change position of obj
        obj.transform.position = Vector3.zero;
    }
}
