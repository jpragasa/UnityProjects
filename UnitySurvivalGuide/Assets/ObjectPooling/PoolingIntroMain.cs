using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingIntroMain : MonoBehaviour
{
    /// <summary>
    /// Object Pooling: Optimization pattern, used for recycling objects
    /// </summary>
    // Start is called before the first frame update

    [SerializeField] private GameObject _bulletPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(PoolManager.Instance);
            // reuse bullets

            // Request Bullet
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = new Vector3(Random.Range(-5, 10), Random.Range(-5, 10),0);
        }
    }
}
