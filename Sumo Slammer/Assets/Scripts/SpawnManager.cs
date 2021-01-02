using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private static SpawnManager _instance;
    [SerializeField] private List<GameObject> _enemyList;
    [SerializeField] private List<GameObject> _enemies;
    [SerializeField] private List<Transform> _parentTransforms;
    [SerializeField] private GameObject _enemyContainer;

    public float xSpawnMin;

    public float xSpawnMax;

    public float zSpawnMin;

    public float zSpawnMax;
    
    [SerializeField] private float _spawnDelayMin;
    [SerializeField] private float _spawnDelayMax;
    public static SpawnManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("SpawnManager does not exist");
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
        GenerateObjects(2);
        StartCoroutine(Spawn());
    }

    public GameObject RequestObject()
    {
        foreach (var obstacle in _enemyList)
        {
            if (obstacle.activeInHierarchy == false)
            {
                obstacle.SetActive(true);
                return obstacle;
            }
        }

        float randomizer = Random.Range(0, _enemies.Count);
        GameObject newObject = Instantiate(_enemies[(int)randomizer]);
        newObject.transform.parent = _enemyContainer.transform;
        newObject.SetActive(true);
        _enemyList.Add(newObject);
        return newObject;
    }

    private List<GameObject> GenerateObjects(int amountOfObjects)
    {
        for (int i = 0; i < amountOfObjects; i++)
        {
            float randomizer = Random.Range(0, _enemies.Count);
            GameObject obj = Instantiate(this._enemies[(int)randomizer]);
            _parentTransforms[(int)randomizer] = _enemyContainer.transform;
            _enemies[(int)randomizer].SetActive(false);
            _enemyList.Add(obj);
        }

        return _enemyList;
    }

    public void DeactivateEnemies()
    {
        foreach(var obj in _enemyList)
        {
            obj.SetActive(false);
        }
    }

    IEnumerator Spawn()
    {
        while(true)
        {            
                GameObject newObj = SpawnManager.Instance.RequestObject();
                newObj.GetComponent<Rigidbody>().velocity = Vector3.zero;
                newObj.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                float randomizerX = Random.Range(xSpawnMin, xSpawnMax);
                float randomizerZ = Random.Range(zSpawnMin, zSpawnMax);
                newObj.transform.position = new Vector3(randomizerX,
                                                    this.transform.position.y, randomizerZ);
                yield return new WaitForSeconds(Random.Range(_spawnDelayMin, _spawnDelayMax));            
        }
    }
}
