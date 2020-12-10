using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMainPoly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                IDamagable obj = hitInfo.collider.GetComponent<IDamagable>();
                if(obj != null)
                {
                    obj.Damage(100);
                }
            }
        }
    }
}
