using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{

    [SerializeField] private float bill;
    [SerializeField] private float tip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            calculateTip();
        }
    }

    private void calculateTip()
    {
        string outValue = String.Format("Bill: {0}\nTip %: {1}\nTotal: {2}", bill, tip, bill + (bill * (tip / 100))).ToString();
        if(outValue == null)
        {
            Debug.Log("Invalid Inputs. Try Again");
        } 
        else
        {
            Debug.Log(outValue);
        }
    }
}
