using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEmployee
{
    float baseSalary { get; }
    IPosition position { get; }
    ISeniority seniority { get; }
    float salaryPercentage { get; }
    string name { get; set; }
    float currentSalary { get; set; }
}

public class Employee : IEmployee
{
    public float baseSalary { get; }
    public IPosition position { get; }
    public ISeniority seniority { get; }
    public float salaryPercentage { get; }
    public string name { get; set; }
    public float currentSalary { get; set; }

    public Employee(string _name, float _baseSalary, IPosition _position, ISeniority _seniority, float _salaryPercentage)
    {
        name = _name;
        baseSalary = _baseSalary;
        position = _position;
        seniority = _seniority;
        salaryPercentage = _salaryPercentage;
        currentSalary = baseSalary;
    }
}
