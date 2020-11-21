using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    // Every Item Has a Name
    // Every Item Has a Description
    // Every Item Has an ImageIcon
    // Every Item Has a attack strength

    [SerializeField] private string Name;
    [SerializeField] private string Description;
    [SerializeField] private float attackStrength;
    [SerializeField] private Sprite image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
