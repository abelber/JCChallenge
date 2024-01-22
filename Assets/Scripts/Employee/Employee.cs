using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEmployee
{
    IBaseSalary baseSalary { get; }
    IPosition position { get; }
    ISeniority seniority { get; }
    ISalaryPercentage salaryPercentage { get; }
    string name { get; set; }
    float currentSalary { get; set; }
}

public class Employee : IEmployee
{
    public IBaseSalary baseSalary { get; }
    public IPosition position { get; }
    public ISeniority seniority { get; }
    public ISalaryPercentage salaryPercentage { get; }
    public string name { get; set; }
    public float currentSalary { get; set; }

    public Employee(string _name, IBaseSalary _baseSalary, IPosition _position, ISeniority _seniority, ISalaryPercentage _salaryPercentage)
    {
        name = _name;
        baseSalary = _baseSalary;
        position = _position;
        seniority = _seniority;
        salaryPercentage = _salaryPercentage;
        currentSalary = baseSalary.BaseSalary;
    }
}
