using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingletonMain<T> : MonoBehaviour where T : MonoSingletonMain<T>
{
    /// <summary>
    /// Monosingleton: The ability to turn any manager class into a singleton and initialize values
    /// </summary>
    // Start is called before the first frame update

    private static T _instance;
    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log(typeof(T).ToString() + "is NULL");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = (T) this;
        Init();
    }

    // this is optional
    public virtual void Init()
    {
        // Optional to override
    }
}
