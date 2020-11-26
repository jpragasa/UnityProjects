using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CChallengeMini : MonoBehaviour
{
    public int speed = 0;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(60, 120);
        StartCoroutine(addSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // While Loops are good for when you want to run code continuously, but without a set number of times you want to iterate
    // For and foreach loops are great for when you now how many iterations you want AND when you are working with Arrays and Collections

    IEnumerator addSpeed()
    {
        while(speed < num)
        {
            speed += 5;
            Debug.Log(string.Format("Current Speed: {0}", speed));
            yield return new WaitForSeconds(1.0f);
        }
        Debug.Log("Too fast! Acceleration is ending.....");
        StopCoroutine(addSpeed());
    }
}
