using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour
{
    // Get the Text Component
    [SerializeField] private Text texter;
    // Create the string (should be static final)
    public string exampleString;
    private string currentText;
    [SerializeField] private float delayX;
    [SerializeField] private float delayY;
    private int counter = 0;
    private int start = 0;
    //private float delay = Random.Range(.01f, .1f);
    private void Start()
    {
        StartCoroutine(UpdateTextWithWait());
    }
    // Create method for having the UI be updating the text at a certain speed (IEnumerator?)
    IEnumerator UpdateTextWithWait()
    {
        for(int i = 0; i <= exampleString.Length; i++)
        {
            if(counter > 20)
            {
                start = i;
                texter.text = "";
                currentText = "";
                counter = 0;
            } 
            else
            {
                currentText = exampleString.Substring(start, i);
                texter.text = currentText;
                counter++;
            }
            currentText = "";
                        
            yield return new WaitForSeconds(Random.Range(delayX, delayY));   
            
        }             
    }
}
