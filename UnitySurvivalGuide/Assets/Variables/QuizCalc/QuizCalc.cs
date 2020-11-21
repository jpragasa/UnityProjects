using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalc : MonoBehaviour
{
    private float grade1, grade2, grade3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            grade1 = Random.Range(0f, 100);
            grade2 = Random.Range(0f, 100);
            grade3 = Random.Range(0f, 100);
            Debug.Log(calculateAverage());
        }
    }

    private float calculateAverage()
    {
        float[] arr = { grade1, grade2, grade3};
        float total = 0;
        foreach(float i in arr)
        {
            total += i;
        }

        return Mathf.Round((total / arr.Length) * 100) / 100f;
    }
}
