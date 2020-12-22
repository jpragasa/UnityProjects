using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    [SerializeField] Text scoreText;
    private int score = 0;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        scoreText.text = string.Format("Score: {0}", score);
    }

    private void FixedUpdate()
    {
        if(PlayerController.Instance.gameObject.activeInHierarchy == false)
        {
            scoreText.text = scoreText.text = string.Format("Player Has Died! Final Score: {0}", score);
        } 
        else
        {
            scoreText.text = scoreText.text = string.Format("Score: {0}", score);
        }
        
    }

    public static UIManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("UIManager does not exit");
            }
            return _instance;
        }
    }

    public void UpdateScore(int amountToAdd)
    {
        score += amountToAdd;
    }
}
