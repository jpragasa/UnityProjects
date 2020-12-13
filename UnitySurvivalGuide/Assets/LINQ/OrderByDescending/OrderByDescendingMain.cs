using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class OrderByDescendingMain : MonoBehaviour
{
    public int[] quizGrades;
    private void Start()
    {
        quizGrades = new int[] { Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100) };

        var passingGrades = quizGrades.Where((n) => n > 69).OrderByDescending(g => g).Reverse();

        foreach (var grade in passingGrades)
        {
            Debug.Log(grade);
        }
    }
}
