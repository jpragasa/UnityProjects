using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public Spell[] spells;

    public int level = 1;
    public int exp;
    private void Start()
    {
        //fireBlast = new Spell("Fire Blast", 1, 27, 35);
    }

    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    fireBlast.Cast();
        //    exp += fireBlast.getExpGained();
        //}

        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach(Spell spell in spells)
            {
                if(spell.levelRequired == level)
                {
                    spell.Cast();
                }
            }
        }
    }
}
