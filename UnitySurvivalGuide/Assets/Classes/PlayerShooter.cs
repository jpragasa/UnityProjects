using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats
{
    public string name;
    public float fireRate;
    public int ammoCount;

    public WeaponStats(string name, float fireRate, int ammoCount)
    {
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
    }
}
public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private GameObject laserPrefab;
    [SerializeField] private Transform firePos;
    [SerializeField] private float _speed;
    private WeaponStats blasters;
    private WeaponStats rockets;
    // Start is called before the first frame update
    void Start()
    {
        blasters = new WeaponStats("Blaster", 05f, 50);       
        rockets = new WeaponStats("Rocket", .25f, 20);
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        Shoot();
    }

    private void CalculateMovement()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hInput, vInput, 0) * _speed * Time.deltaTime);
        if(transform.position.x > 8.5f)
        {
            transform.position = new Vector3(8.5f, transform.position.y, 0);
        }
        else if(transform.position.x < -8.5f)
        {
            transform.position = new Vector3(-8.5f, transform.position.y, 0);
        }

        
    }

    private void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, firePos.position, Quaternion.identity);
        }
    }
}
