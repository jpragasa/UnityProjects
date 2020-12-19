using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float acceleration;
    [SerializeField] private float routineSubtracter;
    [SerializeField] private float waitTime;
    [SerializeField] private float horizontalMovement;
    [SerializeField] private float verticalMovement;
    private void Start()
    {
        StartCoroutine(SlowDown());
    }
    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        if(Input.GetKey(KeyCode.Space))
        {
            speed += acceleration;
        }
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalMovement);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalMovement);

        if(speed <= 0)
        {
            speed = 5;
        }
        if(speed >= 100)
        {
            speed = 100;
        }
    }

    IEnumerator SlowDown()
    {
        while(true)
        {
            speed -= routineSubtracter;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
