using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_ : MonoBehaviour
{

    private void Start()
    {
        EventChallengeMain.space += InstantiateCube;
    }
    public void InstantiateCube()
    {
        GetComponent<Transform>().position = new Vector3(5, 2, 0);
    }

    private void OnDisable()
    {
        EventChallengeMain.space -= InstantiateCube;
    }
}
