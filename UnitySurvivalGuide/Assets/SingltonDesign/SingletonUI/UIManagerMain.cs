using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerMain : MonoBehaviour
{
    // private static instance of the class to use
    private static UIManagerMain _instance;
    public static UIManagerMain Instance
    {
        get
        {
            if(_instance == null)
            {
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

    public void UpdateScore(int score)
    {
        Debug.Log("Score: " + score);
        SingletonIntroMain.Instance.DisplayName();
    }
}
