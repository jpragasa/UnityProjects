using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeArr : MonoBehaviour
{
    [SerializeField] private string[] names;
    [SerializeField] private int[] ages;
    [SerializeField] private string[] carModels;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int randomizer = Random.Range(0, 3);
            Debug.Log(string.Format("Name: {0}, Age: {1}, Favorite Car Model: {2}", names[randomizer], ages[randomizer], carModels[randomizer]));
        }
    }

    private void iterateThroughNames()
    {
        for(int i = 0; i < names.Length; i++)
        {
            if(names[i] == "Enoch")
            {
                Debug.Log(string.Format("Name: {0}, Age: {1}, Favorite Car Model: {2}", names[i], ages[i], carModels[i]));
            }
        }
    }
}
