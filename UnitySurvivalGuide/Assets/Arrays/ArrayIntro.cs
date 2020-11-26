using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayIntro : MonoBehaviour
{
    // Arrays holds multiple of the same data type
    public string[] names = new string[3];
    // Another way of declaring
    public string[] names2;
    // Another way
    public int[] ages = new int[] { 1,2,3,4,5,6};
    // Start is called before the first frame update
    void Start()
    {
        foreach(int i in ages)
        {
            Debug.Log(i);
        }
        for(int j = 0; j < ages.Length; j++)
        {
            Debug.Log(ages[j] + 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
