using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoolManager : MonoBehaviour
{
    private static PoolManager _instance;
    [SerializeField] private GameObject _bulletContainer;
    [SerializeField] private List<GameObject> bullets;
    [SerializeField] private GameObject bullet;
    private void Start()
    {
        bullets = GenerateBullets(10);
    }
    public static PoolManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.Log("Pool Manager Not Found");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    private List<GameObject> GenerateBullets(int amountOfBullets)
    {
        
        for(int i = 0; i < amountOfBullets; i++)
        {
            GameObject obj = Instantiate(this.bullet);
            bullet.transform.parent = _bulletContainer.transform;
            bullet.SetActive(false);
            bullets.Add(obj);
        }
        
        return bullets;
    }

    public GameObject RequestBullet()
    {
        // Loop through the bullet list
        foreach(var bull in bullets)
        {
            if(bull.activeInHierarchy == false)
            {
                // bullet is available
                bull.SetActive(true);
                return bull;
            }
        }

        // Need to create a new bullet

        GameObject newBullet = Instantiate(bullet);
        newBullet.transform.parent = _bulletContainer.transform;
        newBullet.SetActive(true);
        bullets.Add(newBullet);
        return newBullet;

        // Checking for inactive bullet
        // Found One? Set it active and return it to the player
        // if no bullets available (all are turned on)
        // generate x amount of bullets and run the request bullet method

        //return null;
    }
}
