using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private float offset;
    [SerializeField] private int reps;
    private bool flag = false;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation();
    }

    public void rotation()
    {
        counter++;
        if(counter == reps)
        {
            flag = !flag;
            offset = 0;
            counter = 0;
        }
        if(!flag)
        {
            cube.transform.rotation = Quaternion.Euler(cube.transform.rotation.x + offset, cube.transform.rotation.y - offset, 0);
            offset--;
        }
        else
        {
            cube.transform.rotation = Quaternion.Euler(cube.transform.rotation.x - offset, cube.transform.rotation.y + offset, 0);
            offset--;
        }
    }
}
