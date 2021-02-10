﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI : MonoBehaviour
{


    /// <summary>
    /// NOTES:
    /// - Whenever you want to use reuse the text and image UI, just set the texObj and imageObj active
    ///   and inactive accordingly
    /// </summary>

    [SerializeField] private string _name;
    [SerializeField] private string _text;    
    [SerializeField] private Transform _textContainer;
    [SerializeField] private Transform _imageContainer;
    [SerializeField] private GameObject _textObj;
    [SerializeField] private GameObject _imageObj;
    [SerializeField] private Transform _player;
    [SerializeField] private float delayX;
    [SerializeField] private float delayY;
    private string currentText;
    private bool flag = false;
    public AI(string name, string text)
    {
        this._name = name;
        this._text = text;
    }

    public string getName()
    {
        return _name;
    }

    public string getText()
    {
        return _text;
    }

    private void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Transform>();
    }

    private void FixedUpdate()
    {        
        if(_player.position.x - transform.position.x < 10) 
        {
            Vector3 directionToFace = _player.position - transform.position;
            Debug.Log(_player.position.x - transform.position.x);
            Debug.DrawRay(transform.position, directionToFace, Color.cyan);
            Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
        }                             
    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.CompareTag("AI") && other.gameObject.CompareTag("Player"))
        {
            flag = true;
            if (flag && Input.GetKey(KeyCode.Space))
            {
                _textObj.SetActive(true);
                _imageObj.SetActive(true);
                UIManager.Instance.ResetText();
                StartCoroutine(UpdateTextWithWait());
            }
            else
            {
                // Do Nothing
            }                       
        }
    }

    IEnumerator UpdateTextWithWait()
    {
        int counter = 0;
        UIManager.Instance.ResetText();
        while(counter <= _text.Length)
        {
            currentText = _text.Substring(0, counter);
            UIManager.Instance.ChangeText(currentText);
            UIManager.Instance.TextAndImageTransform(_textContainer);
            counter++;
            yield return new WaitForSeconds(Random.Range(delayX, delayY));
        }
        
        flag = false;
        if(!flag)
        {
            Debug.Log("Connected");
            yield return new WaitForSeconds(1f);
            _textObj.SetActive(false);
            _imageObj.SetActive(false);
        }
    }
}