using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabaseUno : MonoBehaviour
{
    public List<ItemClassUno> itemDB = new List<ItemClassUno>();
    private void Start()
    {
        itemDB[0].Action();
    }
}
