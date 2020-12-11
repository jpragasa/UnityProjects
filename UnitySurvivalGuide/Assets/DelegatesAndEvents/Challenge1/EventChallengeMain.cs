using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventChallengeMain : MonoBehaviour
{
    public delegate void SpaceClick();
    public static event SpaceClick space;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            space();
        }
    }
}
