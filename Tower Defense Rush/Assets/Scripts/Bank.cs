using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField] int currentBalance = 0;
    UIManager ui;
    public int CurrentBalance { get { return currentBalance; } private set { currentBalance = value; } }

    private void Awake()
    {
        ui = FindObjectOfType<UIManager>();
        currentBalance = startingBalance;
        ui.UpdateScore();
    }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        ui.UpdateScore();
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        ui.UpdateScore();
        if (currentBalance < 0)
        {
            ReloadScene();
        }
    }

    void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
        currentBalance = 0;
        ui.UpdateScore();
    }
}
