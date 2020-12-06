using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConn
{
    public string name { get; set; }
    public int id { get; set; }

    public PlayerConn(string name, int id)
    {
        this.id = id;
        this.name = name;
    }

}
public class PlayerConnMain : MonoBehaviour
{
    public Dictionary<int, PlayerConn> playerDictionary = new Dictionary<int, PlayerConn>();
    private void Start()
    {
        PlayerConn p1 = new PlayerConn("Josh", 1);
        PlayerConn p2 = new PlayerConn("Jackie", 2);
        PlayerConn p3 = new PlayerConn("Paityn", 3);
        playerDictionary.Add(p1.id, p1);
        playerDictionary.Add(p2.id, p2);
        playerDictionary.Add(p3.id, p3);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach (KeyValuePair<int, PlayerConn> p in playerDictionary)
            {
                Debug.Log(p.Value.name + " " + p.Value.id);
            }
        }
    }
}
