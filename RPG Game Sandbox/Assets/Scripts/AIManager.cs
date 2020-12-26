using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIManager : MonoBehaviour
{
    private static AIManager _instance;
    [SerializeField] private List<AI> _aiList;
    
    public static AIManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("AI Manager Not Found");
            }

            return _instance;
        }
    }

    public AI RequestAI(string name)
    {
        foreach(AI obj in _aiList)
        {
            if(name == obj.getName())
            {
                return obj;
            }
        }
        return null;
    }

    private void Awake()
    {
        _instance = this;
    }
}
