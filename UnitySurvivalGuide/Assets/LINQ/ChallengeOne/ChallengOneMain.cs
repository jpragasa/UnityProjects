using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChallengOneMain : MonoBehaviour
{
    public int[] quizGrades;
    private void Start()
    {
        quizGrades = new int[] { Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100) };

        var passingGrades = quizGrades.Where((n) => n > 69);

        foreach(var grade in passingGrades)
        {
            Debug.Log(grade);
        }
    }
}
