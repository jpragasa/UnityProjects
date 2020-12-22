using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private static SpawnManager _instance;
    [SerializeField] private GameObject _animalContainer;
    [SerializeField] private List<GameObject> _animalList;
    [SerializeField] private List<GameObject> animals;
    [SerializeField] private List<Transform> parentTransform;
    [SerializeField] private float[] _spawnPositionsX;
    [SerializeField] private float zOffset;
    [SerializeField] private float _instantiationSpeed;
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

    private List<GameObject> GenerateAnimals(int amountOfAnimals)
    {
        for(int i = 0; i < amountOfAnimals; i++)
        {
            float randomizer = Random.Range(0, animals.Count);
            GameObject obj = Instantiate(this.animals[(int)randomizer]);
            parentTransform[((int)randomizer)] = _animalContainer.transform;
            animals[(int)randomizer].SetActive(false);
            _animalList.Add(obj);
        }

        return _animalList;
    }

    public GameObject RequestAnimal()
    {
        foreach (var animal in _animalList)
        {
            if (animal.activeInHierarchy == false)
            {
                animal.SetActive(true);
                return animal;
            }
        }
        float randomizer = Random.Range(0, animals.Count);
        GameObject newAnimal = Instantiate(animals[(int)randomizer]);
        newAnimal.transform.parent = _animalContainer.transform;
        newAnimal.SetActive(true);
        _animalList.Add(newAnimal);
        return newAnimal;
    }

    private void Start()
    {
        GenerateAnimals(2);
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(true)
        {
            GameObject newAnimal = SpawnManager.Instance.RequestAnimal();
            newAnimal.transform.position = new Vector3(_spawnPositionsX[Random.Range(0, _spawnPositionsX.Length)], this.transform.position.y, this.transform.position.z + zOffset);
            yield return new WaitForSeconds(_instantiationSpeed);
        }
        
    }
}
