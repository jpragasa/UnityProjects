using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = GetPosition(2, 10, 6);
    }

    // Update is called once per frame
    void Update()
    {
        // changePosition(Vector3.left);
    }

    public void changePosition(Vector3 pos)
    {
        transform.position =pos;
    }

    public Vector3 GetPosition(float x, float y, float z)
    {
        return new Vector3(x, y, z);
    }
}
