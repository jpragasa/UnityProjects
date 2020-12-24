using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    [SerializeField] Text scoreText;
    [SerializeField] Text timerText;
    [SerializeField] private float levelTime;
    private int score = 0;
    private float timer = 0f;
    
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
        if(PlayerController.Instance.gameObject.activeInHierarchy == false || (int)timer == (int)levelTime)
        {
            if((int)timer == (int)levelTime)
            {
                PlayerController.Instance.gameObject.SetActive(false);
                scoreText.text = scoreText.text = string.Format("Times Up! Final Score: {0}", score);
            }
            else
            {
                scoreText.text = scoreText.text = string.Format("Game Over! Final Score: {0}", score);
            }
            
            if(PlayerController.Instance.gameObject.activeInHierarchy == false)
            {
                StartCoroutine(ResetGame());
            }
        } 
        else
        {
            scoreText.text = scoreText.text = string.Format("Score: {0}", score);
            timer += Time.deltaTime;
            timerText.text = string.Format("Timer: {0}", (int)timer);
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

    public void SubtractScore(int amountToSubtract)
    {
        score -= amountToSubtract;
    }

    private IEnumerator ResetGame()
    {
        yield return new WaitForSeconds(2f);
        SpawnManager.Instance.SetAnimalsInactive();
        PlayerController.Instance.gameObject.SetActive(true);
        score = 0;
        timer = 0f;
    }
}
