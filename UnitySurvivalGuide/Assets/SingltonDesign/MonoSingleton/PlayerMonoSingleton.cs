using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMonoSingleton : MonoSingletonMain<PlayerMonoSingleton>
{
    // Thanks to the abstract monosingleton class, this class is automatically a singleton
    public string name;

    private void Start()
    {
        name = "Josh";
    }

    public override void Init()
    {
        Debug.Log("Player Initialized");
        LevelManager.Instance.LoadLevel();
    }
}
