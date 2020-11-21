using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text textChanger;
    [SerializeField] private InputField inputField;
    void Start()
    {
        textChanger = gameObject.GetComponent<Text>();
        textChanger.text = "Hello";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            try
            {
                this.textChanger.text = inputField.text.ToString();
            } catch(NullReferenceException e)
            {
                // Do Nothing
            }
            
        }
    }
}
