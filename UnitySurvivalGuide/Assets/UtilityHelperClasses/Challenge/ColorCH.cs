using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorCH : MonoBehaviour
{
    [SerializeField] private Text enemyCount;
    private void Start()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ColorHelper.CreateObject();
            enemyCount.text = string.Format("Enemies: {0}", ColorHelper.createdObjects);
            Invoke("subtracter", 5f);
        }
    }

    public void subtracter()
    {
        ColorHelper.createdObjects--;
        enemyCount.text = string.Format("Enemies: {0}", ColorHelper.createdObjects);
    }
}
