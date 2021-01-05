using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    private static SpawnManager _instance;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private int _score;
    [SerializeField] private List<GameObject> _enemyList;
    [SerializeField] private List<GameObject> _enemies;
    [SerializeField] private List<Transform> _parentTransform;
    ///[SerializeField] private List<Transform> _parentTransform;
    [SerializeField] private GameObject _enemyContainer;
    [SerializeField] private float _spawnDelayMin = 3f;
    [SerializeField] private float _spawnDelayMax = 6f;
    [SerializeField] private TextMeshProUGUI _gameOverText;
    [SerializeField] private TextMeshProUGUI _livesText;
    private int originalLives;
    [SerializeField] public int lives = 3;
    [SerializeField] private Button _resetButton; 
    private static GameObject previous;
    private static GameObject _oneBeforePrevious;
    public bool isGameOver = false;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip gameOverClip;
    public static SpawnManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("Spawn Manager does not exist");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        _oneBeforePrevious = null;
        GenerateEnemies(_enemies.Count);
        StartCoroutine(Spawn());
        originalLives = lives;
        _score = 0;
        _scoreText.text = string.Format("Score: {0}", _score);
        _livesText.text = string.Format("Lives: {0}", lives);
    }

    public GameObject RequestEnemy()
    {
        foreach(var enemy in _enemyList)
        {
            if(enemy.activeInHierarchy == false && enemy != previous && enemy != _oneBeforePrevious)
            {
                enemy.SetActive(true);
                _oneBeforePrevious = previous;
                if(_oneBeforePrevious == null)
                {
                    previous = enemy;
                    return enemy;
                }
                else
                {
                    previous = enemy;
                    return enemy;
                }                
            }
        }

        float randomizer = Random.Range(0, _enemies.Count);
        GameObject newEnemy = Instantiate(_enemies[(int)randomizer]);
        newEnemy.transform.parent = _enemyContainer.transform;
        newEnemy.SetActive(true);
        _enemyList.Add(newEnemy);
        return newEnemy;
    }

    public void UpdateScore(int amountToAdd)
    {
        _score += amountToAdd;
        _scoreText.text = string.Format("Score: {0}", _score);
    }

    public void UpdateLives()
    {
        lives--;
        _livesText.text = string.Format("Lives: {0}", lives);
    }

    public void GameOver()
    {
        audioSource.PlayOneShot(gameOverClip, 1.0f);
        isGameOver = true;
        DeactivateEnemies();
        _gameOverText.gameObject.SetActive(true);
        _resetButton.gameObject.SetActive(true);
    }

    public void ResetGame()
    {
        _gameOverText.gameObject.SetActive(false);
        _resetButton.gameObject.SetActive(false);
        lives = originalLives;
        _score = 0;
        _scoreText.text = string.Format("Score: {0}", _score);
        _livesText.text = string.Format("Lives: {0}", lives);
        isGameOver = false;
        StartCoroutine(Spawn());
    }

    public void DeactivateEnemies()
    {
        foreach(var obj in _enemyList)
        {
            obj.SetActive(false);
        }
    }

    private List<GameObject> GenerateEnemies(int amountOfEnemies)
    {
        for(int i = 0; i < amountOfEnemies; i++)
        {
            //float randomizer = Random.Range(0, _enemies.Count);
            GameObject obj = Instantiate(this._enemies[i]);
            _parentTransform[i] = _enemyContainer.transform;
            _enemies[i].SetActive(false);
            _enemyList.Add(obj);
        }

        return _enemyList;
    }

    public void PlayAudioClip(AudioClip ac)
    {
        GetComponent<AudioSource>().PlayOneShot(ac, 1.0f);
    }

    IEnumerator Spawn()
    {
        while(!isGameOver)
        {
            GameObject obj = Instance.RequestEnemy();
            obj.transform.position = new Vector3(Random.Range(-4, 4), -4);
            yield return new WaitForSeconds(Random.Range(_spawnDelayMin, _spawnDelayMax));
        }

        if(isGameOver)
        {
            GameOver();
        }
    }
}
