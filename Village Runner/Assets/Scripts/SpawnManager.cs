using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _obstacleList;
    [SerializeField] private GameObject _obstacleContainer;
    [SerializeField] private List<GameObject> _obstacles;
    [SerializeField] private float[] _xSpawanPositions;
    [SerializeField] private float _yOffset;
    [SerializeField] private float delayMin;
    [SerializeField] private float delayMax;
    [SerializeField] private List<Transform> _parentTransform;

    private static SpawnManager _instance;
    public static SpawnManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("Spawn Manager Does Not Exist");
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
        GenerateObstacles(2);
        StartCoroutine(Spawn());
    }

    private List<GameObject> GenerateObstacles(int obstacleCount)
    {
        for(int i = 0; i < obstacleCount; i++)
        {
            float randomizer = Random.Range(0, _obstacles.Count);
            GameObject obj = Instantiate(this._obstacles[(int)randomizer]);
            _parentTransform[(int)randomizer] = _obstacleContainer.transform;
            _obstacles[(int)randomizer].SetActive(false);
            _obstacleList.Add(obj);
        }

        return _obstacleList;
    }

    public GameObject RequestObstacle()
    {
        foreach(var obstacle in _obstacleList)
        {
            if(obstacle.activeInHierarchy == false)
            {
                obstacle.SetActive(true);
                return obstacle;
            }
        }

        float randomizer = Random.Range(0, _obstacles.Count);
        GameObject newObject = Instantiate(_obstacles[(int)randomizer]);
        newObject.transform.parent = _obstacleContainer.transform;
        newObject.SetActive(true);
        _obstacleList.Add(newObject);
        return newObject;
    }

    public void SetInActive()
    {
        foreach(GameObject obj in _obstacleList)
        {
            obj.SetActive(false);
        }
    }

    IEnumerator Spawn()
    {
        while(true)
        {
            GameObject newObstacle = SpawnManager.Instance.RequestObstacle();
            newObstacle.transform.position = new Vector3(_xSpawanPositions[Random.Range(0, _xSpawanPositions.Length)], this.transform.position.y + _yOffset, this.transform.position.z);
            yield return new WaitForSeconds(Random.Range(delayMin, delayMax));
        }
    }
}
