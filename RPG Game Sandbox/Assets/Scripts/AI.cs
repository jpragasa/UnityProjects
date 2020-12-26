using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private string _text;    
    [SerializeField] private Transform _textContainer;
    [SerializeField] private Transform _imageContainer;
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

    private void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.CompareTag("AI") && other.gameObject.CompareTag("Player"))
        {
            flag = true;
            if (flag && Input.GetKey(KeyCode.Space))
            {
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
    }
}
