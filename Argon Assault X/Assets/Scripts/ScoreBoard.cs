using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public static int score = 0;
    static TMP_Text text;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
        text.SetText("Score: 0");
    }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        text.SetText($"Score: {score}");
    }

    public static void ResetScore()
    {
        score = 0;
        text.SetText("Score: 0");
    }
}
