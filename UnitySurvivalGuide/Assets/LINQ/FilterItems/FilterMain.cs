using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class FilterItem
{
    public string name;
    public int id;
    public int buff;

}
public class FilterMain : MonoBehaviour
{
    public List<FilterItem> items;

    private void Start()
    {
        var findItem = items.Where((i) => i.id == 3);
        foreach(var item in findItem)
        {
            if(item.id == 3)
            {
                Debug.Log("Does item 3 exist?: " + item.name);
            }
        }
        

        var allItemsWithTwentyBuff = items.Where((i) => i.buff > 20);
        foreach(var item in allItemsWithTwentyBuff)
        {
            Debug.Log(item.name + " has a buff above 20.");
        }
        /*
        var allItems = items.Where((n) => n.buff > 0);
        int average = 0;
        
        foreach(var item in allItems)
        {
            average += item.buff;
        }

        Debug.Log("The average of all buffs is: " + average / items.Count);
        */
        var allItems = items.Average(item => item.buff);
        Debug.Log("Average: " + allItems);
    }
}
