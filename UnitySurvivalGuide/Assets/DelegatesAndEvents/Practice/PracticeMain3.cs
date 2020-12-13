using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeMain3 : MonoBehaviour
{
    /// <summary>
    /// If the delegate you want has no return type, use Action
    /// if the delegate you want has a return type, use Func
    /// </summary>
    public Func<int> LengthOfName;

    private void Start()
    {
        LengthOfName = () => {
            return this.gameObject.name.Length;
        };
        Debug.Log("This GameObject's name has a length of: " + LengthOfName());
    }
}
