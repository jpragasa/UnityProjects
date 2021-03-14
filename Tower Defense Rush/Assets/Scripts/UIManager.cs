using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text score;
    Bank bank;
    private void Awake()
    {
        score = GetComponent<TMP_Text>();
        bank = FindObjectOfType<Bank>();
    }

    public void UpdateScore()
    {
        try
        {
            score.text = $"Gold: {bank.CurrentBalance}";
        }
        catch(NullReferenceException e)
        {
            // Do Nothing
        }
    }
}
