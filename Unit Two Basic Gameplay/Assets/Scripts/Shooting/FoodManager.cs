using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FoodManager : MonoBehaviour
{
    private static FoodManager _instance;
    [SerializeField] private GameObject _foodContainer;
    [SerializeField] private List<GameObject> _foodList;
    [SerializeField] private List<GameObject> food;
    [SerializeField] private List<Transform> parentTransform;
    

    private void Start()
    {
        _foodList = GenerateFood(10);
    }
    public static FoodManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("Food Manager Not Found");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    private List<GameObject> GenerateFood(int foodAmount)
    {
        for (int i = 0; i < foodAmount; i++)
        {
            float randomizer = Random.Range(0, food.Count);
            GameObject obj = Instantiate(this.food[(int)randomizer]);           
            parentTransform[((int)randomizer)] = _foodContainer.transform;
            food[(int)randomizer].SetActive(false);
            _foodList.Add(obj);
        }

        return _foodList;
    }

    public GameObject RequestFood()
    {
        foreach(var foodItem in _foodList)
        {
            if (foodItem.activeInHierarchy == false)
            {
                foodItem.SetActive(true);
                return foodItem;
            }
        }
        float randomizer = Random.Range(0, food.Count);
        GameObject newFood = Instantiate(food[(int)randomizer]);
        newFood.transform.parent = _foodContainer.transform;
        newFood.SetActive(true);
        _foodList.Add(newFood);
        return newFood;
    }
}
