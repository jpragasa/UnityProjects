using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    [SerializeField] private Text _text;
    [SerializeField] private Image _image;
    public string text;
    private Transform tempTr1;
    private Transform tempTr2;

    private void Start()
    {
        tempTr1 = null;
        tempTr2 = null;
    }
    public static UIManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("UI Manager Not Found");
            }

            return _instance;
        }
    }

    private void FixedUpdate()
    {
        try
        {
            _text.text = text;
            Vector3 pos1 = Camera.main.WorldToScreenPoint(new Vector3(tempTr1.position.x, tempTr1.position.y + 1, tempTr1.position.z));
            _text.transform.position = pos1;
            Vector3 pos2 = Camera.main.WorldToScreenPoint(new Vector3(tempTr2.position.x, tempTr2.position.y + 1, tempTr2.position.z));
            _image.transform.position = pos2;
        } 
        catch(NullReferenceException e)
        {
            // Do Nothing
        }       
    }

    public void ChangeText(string str)
    {
        text = str;
    }

    public void TextAndImageTransform(Transform tr1)
    {
        tempTr1 = tr1;
        tempTr2 = tr1;
    }

    public void ResetText()
    {
        _text.text.Trim();
        text.Trim();
        Vector3 pos_1 = new Vector3(-15f, -15f, -15f);
        Vector3 pos_2 = new Vector3(-15f, -15f, -15f);
        Vector3 pos1 = Camera.main.WorldToScreenPoint(pos_1);
        _text.transform.position = pos1;
        Vector3 pos2 = Camera.main.WorldToScreenPoint(pos_2);
        _image.transform.position = pos2;
    }

    private void Awake()
    {
        _instance = this;
    }
}
