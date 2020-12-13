using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonIntroMain : MonoBehaviour
{
    /// <summary>
    /// Singlton: having one global access to a class
    /// - Useful for GameManager classes
    /// </summary>
    // Start is called before the first frame update

    private static SingletonIntroMain _instance;
    public static SingletonIntroMain Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("Game Manager is NULL");
                return null;
            }
            else
            {
                return _instance;
            }
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void DisplayName()
    {
        Debug.Log("I am Josh");
    }
}
