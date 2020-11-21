using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColors : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    private int _switcher = 0;
    // Start is called before the first frame update
    void Start()
    {
        obj.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
        switcher();
    }

    private void getInput()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            _switcher = 1;
        } else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            _switcher = 2;
        } else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            _switcher = 3;
        } else if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            _switcher = 0;
        }
    }

    private void switcher()
    {
        switch(_switcher)
        {
            case 0:
                obj.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 1:
                obj.gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 2:
                obj.gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 3:
                obj.gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;
            default:
                obj.gameObject.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
}
