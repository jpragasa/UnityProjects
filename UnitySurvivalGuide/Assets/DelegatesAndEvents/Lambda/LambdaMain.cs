using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaMain : MonoBehaviour
{
    // string is the param, int is the return type
    public Func<string, int> CharacterLength;

    private void Start()
    {
        CharacterLength = (name) => name.Length;
        int count = CharacterLength("Josh");
        Debug.Log(count);
    }


    /*
    int GetCharacters(string name)
    {
        return name.Length;
    }
    */


    /// Lambdas allow us to write inline functions/methods
}
