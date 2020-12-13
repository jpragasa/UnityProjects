using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Runtime.InteropServices;

public class RAndQmain : MonoBehaviour
{
    //Query Syntax: when using SQL and others
    int[] scores = new int[] { 22, 33, 44, 55 };

    private void Start()
    {
        var scoreQuerySyntax =
            from score in scores
            where score > 80
            select score;

        // This is the same as above
        var scoreQuery = scores.Where(score => score > 80);

        foreach(var score in scoreQuery)
        {
            Debug.Log("Score: " + score);
        }
    }
}
