using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JItem
{
    public string name;
    public int itemID;

    public static int itemCount;

    public JItem()
    {
        itemCount++;
    }
}

public class Player 
{
    public int id;
    public string name;
    public static int connectionCount;

    public Player()
    {
        connectionCount++;
    }
}

public class InstanceVsStatic : MonoBehaviour
{
    /*
     * Instance Vs. Static members
     * Static: Lives through the life of the program
     * Instance: Are instances of a member, usually does not have a prolonged life
     */

    private void Start()
    {
        

        // Access static through the class itself rather than the instance
        JItem.itemCount = 55;
        JItem sword = new JItem();
        JItem bread = new JItem();
        Debug.Log("Item Count: " + JItem.itemCount);

        Player p1 = new Player();
        Player p2 = new Player();
        Player p3 = new Player();

        Debug.Log(Player.connectionCount);
    }
}
