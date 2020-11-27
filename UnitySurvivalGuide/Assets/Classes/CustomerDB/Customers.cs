using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customers
{
    [SerializeField] private string firstName;
    [SerializeField] private string lastName;
    [SerializeField] private int age;
    [SerializeField] private string gender;
    [SerializeField] private string occupation;

    public Customers(string firstName, string lastName, int age, string gender, string occupation)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }

    public string getFullName()
    {
        return firstName + " " + lastName;
    }

    public int getAge()
    {
        return this.age;
    }

    public string getGender()
    {
        return this.gender;
    }

    public string getOccupation()
    {
        return this.occupation;
    }
}
