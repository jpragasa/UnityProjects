using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictWithPrimMain : MonoBehaviour
{
    // You can only access dictionary elements through their key
    public Dictionary<int, string> people = new Dictionary<int, string>();
    void Start()
    {
        people.Add( 0, "Josh");
        people.Add( 1,"James");
        people.Add( 2, "Paityn");
        people.Add( 3,"Yin");

        string paitynsAge = people[0];
        Debug.Log("Paityns Age: " + paitynsAge);

        foreach(KeyValuePair<int, string> p in people)
        {
            Debug.Log(p.Key + ": " + p.Value);
        }
    }

    
}
