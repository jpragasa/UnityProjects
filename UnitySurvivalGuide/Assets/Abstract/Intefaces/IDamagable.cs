using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// T signifies that it is a generiic type
public interface IDamagable
{
    int Health { get; set; }

    void Damage(int damageAmount);

   

}
