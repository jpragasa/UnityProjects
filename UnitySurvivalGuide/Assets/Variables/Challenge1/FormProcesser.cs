using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormProcesser : MonoBehaviour
{
    [SerializeField] InputField Health;
    [SerializeField] InputField Name;
    [SerializeField] InputField Age;
    [SerializeField] InputField Speed;
    public Text form;

    private void Start()
    {
        form = gameObject.GetComponent<Text>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            try
            {
                
                this.form.text = String.Format("Name: {0}\n\nAge: {1}\n\nSpeed: {2}\n\nHealth: {3}\n", Name.text.ToString(), Age.text.ToString(), Speed.text.ToString(), Health.text.ToString()).ToString();
            } catch(NullReferenceException e)
            {
                // Do Nothing
            }
            
        }
    }
}
