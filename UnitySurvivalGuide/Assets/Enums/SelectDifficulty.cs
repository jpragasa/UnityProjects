using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public enum LevelSelector
    {
        // You can also assign them to integer values: Easy = 0 or Normal = 1
        Easy, // 0
        Normal, // 1
        Hard, // 2
        Expert // 3
    }

    public LevelSelector currentLevel;

    private void Start()
    {
        switch(currentLevel)
        {
            case LevelSelector.Easy:
                break;
            case LevelSelector.Normal:
                break;
            case LevelSelector.Hard:
                break;
            case LevelSelector.Expert:
                break;
        }
    }
}
