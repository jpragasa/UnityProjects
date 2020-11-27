using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CustomersDB : MonoBehaviour
{
    public Customers[] customers;
    ///private Customers josh;
    ///private Customers jackie;
    ///private Customers paityn;
    // Start is called before the first frame update
    void Start()
    {
        /**josh = CreateCustomer("Josh", "Ragasa", 25, "Male", "Developer");
        jackie = CreateCustomer("Jackie", "St.John", 23, "Female", "CPA");
        paityn = CreateCustomer("Paityn", "Maynard", 22, "Female", "Devops Engineer"); 
         * 
         */
             
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private Customers CreateCustomer(string firstName, string lastName, int age, string gender, string occupation)
    {
        return new Customers(firstName, lastName, age, gender, occupation);
    }*/
}
