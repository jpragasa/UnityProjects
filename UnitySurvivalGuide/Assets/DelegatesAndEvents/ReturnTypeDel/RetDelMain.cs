// need this for action and func
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetDelMain : MonoBehaviour
{

    /// <summary>
    /// void delegate: no return, used as a callback system
    /// non-void: 
    /// </summary>
    /// 

    //public delegate int CharacterLength(string name);
    public Func<string, int> CharacterLength;

    // Start is called before the first frame update
    void Start()
    {
        //CharacterLength cl = new CharacterLength(GetCharacters);

        // code
        // code

        //Debug.Log(cl("John"));

        // This line subscribes GetCharacters to CharacterLength
        CharacterLength = GetCharacters;
        int count = CharacterLength("Jonathan");
        Debug.Log(count);
    }

    int GetCharacters(string name)
    {
        return name.Length;
    }
    
}
