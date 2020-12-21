using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float constraintMin;
    [SerializeField] private float constraintMax;
    
    private void Control()
    {
        horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;    
        transform.Translate(new Vector3(horizontalInput, 0, 0));
        transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, constraintMin, constraintMax), this.transform.position.y, this.transform.position.z);        
    }

    void Update()
    {
        Control();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject foodToThrow = FoodManager.Instance.RequestFood();
            foodToThrow.transform.position = this.transform.position;
        }
    }
}
