using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour
{
    public string sampleText;
    public Text texter;
    public string currentText;

    private void Start()
    {
        StartCoroutine(TextChanger());
    }

    IEnumerator TextChanger()
    {
        for(int i = 0; i <= sampleText.Length; i++)
        {
            currentText = sampleText.Substring(0, i);
            texter.text = currentText;
            yield return new WaitForSeconds(Random.Range(.1f, 1f));
        }
    }
}
