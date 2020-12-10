using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EmployeeExperienceMain : MonoBehaviour
{
    public static string companyName;
    public string employeeName;

    public abstract void CalculateMonthlySalary();
}

public class FullTimeEmployee : EmployeeExperienceMain
{
    public double salary;
    public override void CalculateMonthlySalary()
    {
        Debug.Log("Monthly Salary is: " + salary / 12);
    }

    private void Start()
    {
        salary = 200000;
        Debug.Log("Yearly Salary is: " + salary);
        CalculateMonthlySalary();
    }
}

public class PartTimeEmployee : EmployeeExperienceMain
{
    public int hoursWorked { get; set; }
    public double hourlyRate { get; set; }

    public override void CalculateMonthlySalary()
    {
        Debug.Log("Monthly Salary: " + hoursWorked * hourlyRate);
    }

    private void Start()
    {
        hoursWorked = 400;
        hourlyRate = 12.5;
        CalculateMonthlySalary();
    }
}
