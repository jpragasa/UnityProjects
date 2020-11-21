using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSetup : MonoBehaviour
{

    [SerializeField] private int WeaponID;
    

    // Start is called before the first frame update
    void Start()
    {
        WeaponID = 0;
    }

    // Update is called once per frame
    void Update()
    {
        weaponSelect();
    }

    private void weaponSelect()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            WeaponID = 1;
            weaponIdentifier();
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            WeaponID = 2;
            weaponIdentifier();
        } 
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            WeaponID = 3;
            weaponIdentifier();
        }
        else if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            WeaponID = 0;
            weaponIdentifier();
        }
    }

    private void weaponIdentifier()
    {
        switch(WeaponID)
        {
            case 1:
                Debug.Log("Gun Equipped");
                break;
            case 2:
                Debug.Log("Knife Equipped");
                break;
            case 3:
                Debug.Log("Machine Gun Equipped");
                break;
            default:
                Debug.Log("No Weapon Equipped");
                break;
        }
    }
}
