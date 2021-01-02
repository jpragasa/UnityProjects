using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PickupManager : MonoBehaviour
{
    private static PickupManager _instance;
    [SerializeField] private List<GameObject> _pickupList;
    [SerializeField] private List<GameObject> _pickUps;
    [SerializeField] private List<Transform> _parentTransforms;
    [SerializeField] private GameObject _pickupContainer;

    public float xSpawnMin;

    public float xSpawnMax;

    public float zSpawnMin;

    public float zSpawnMax;

    [SerializeField] private float _spawnDelayMin;
    [SerializeField] private float _spawnDelayMax;
    public static PickupManager Instance
    {
        get
        {
            if (_instance == null)
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
        GenerateObjects(_pickUps.Count);
        StartCoroutine(Spawn());
    }

    public GameObject RequestObject()
    {
        float randomizer = Random.Range(0, _pickupList.Count);
        foreach (var obstacle in _pickupList)
        {
            if (obstacle.activeInHierarchy == false && obstacle == _pickupList[(int)randomizer])
            {
                obstacle.SetActive(true);
                return obstacle;
            }
        }

        float randomizer2 = Random.Range(0, _pickUps.Count);
        GameObject newObject = Instantiate(_pickUps[(int)randomizer2]);
        newObject.transform.parent = _pickupContainer.transform;
        newObject.SetActive(true);
        _pickupList.Add(newObject);
        return newObject;
    }

    private List<GameObject> GenerateObjects(int amountOfObjects)
    {
        for (int i = 0; i < amountOfObjects; i++)
        {
            //float randomizer = Random.Range(0, _pickUps.Count);
            GameObject obj = Instantiate(this._pickUps[i]);
            _parentTransforms[i] = _pickupContainer.transform;
            _pickUps[i].SetActive(false);
            _pickupList.Add(obj);
        }

        return _pickupList;
    }

    public void DeactivateEnemies()
    {
        foreach (var obj in _pickupList)
        {
            obj.SetActive(false);
        }
    }

    IEnumerator Spawn()
    {
        while (true)
        {
                GameObject newObj = PickupManager.Instance.RequestObject();
                float randomizerX = Random.Range(xSpawnMin, xSpawnMax);
                float randomizerZ = Random.Range(zSpawnMin, zSpawnMax);
                newObj.transform.position = new Vector3(randomizerX,
                                                    this.transform.position.y, randomizerZ);
                yield return new WaitForSeconds(Random.Range(_spawnDelayMin, _spawnDelayMax));
        }
    }
}
