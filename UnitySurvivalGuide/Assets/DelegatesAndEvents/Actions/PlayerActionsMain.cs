// System namespace is needed to use Actions
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerActionsMain : MonoBehaviour
{
    public int Health { get; set; }

    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamage;
    // An action is basically a much cleaner delegate. It doesn't even need an event like the example above
    public static Action<int> onDamageReceived;

    // Start is called before the first frame update
    void Start()
    {
        Health = 10;
    }

    void Damage()
    {
        Health--;
        if(onDamageReceived != null)
        {
            onDamageReceived(Health);
        }
    }
}
