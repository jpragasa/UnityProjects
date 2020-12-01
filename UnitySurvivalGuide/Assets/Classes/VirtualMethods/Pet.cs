using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    protected string petName;

    // Virtual has to be implemented if you want that class's child classes to be able to override it
    protected virtual void Speak()
    {
        Debug.Log("Speak!");
    }

    private void Start()
    {
        Speak();
    }
}
