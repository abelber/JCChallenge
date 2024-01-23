using System.Collections.Generic;
using UnityEngine;

public class CreateEmployessGenerationTest
{
    public List<IEmployee> GenerateEmployeesForTest()
    {
        var list = new List<IEmployee>();

        EmployeeFactory itemFactory = new EmployeeFactory();
        itemFactory.Init();

        list.AddRange(itemFactory.CreateEmployeesGroup(13, PositionType.HR, SeniorityType.Junior));
        list.AddRange(itemFactory.CreateEmployeesGroup(2, PositionType.HR, SeniorityType.SemiSenior));
        list.AddRange(itemFactory.CreateEmployeesGroup(5, PositionType.HR, SeniorityType.Senior));
        list.AddRange(itemFactory.CreateEmployeesGroup(32, PositionType.Engineering, SeniorityType.Junior));
        list.AddRange(itemFactory.CreateEmployeesGroup(68, PositionType.Engineering, SeniorityType.SemiSenior));
        list.AddRange(itemFactory.CreateEmployeesGroup(50, PositionType.Engineering, SeniorityType.Senior));
        list.AddRange(itemFactory.CreateEmployeesGroup(20, PositionType.Artist, SeniorityType.SemiSenior));
        list.AddRange(itemFactory.CreateEmployeesGroup(5, PositionType.Artist, SeniorityType.Senior));
        list.AddRange(itemFactory.CreateEmployeesGroup(15, PositionType.Design, SeniorityType.Junior));
        list.AddRange(itemFactory.CreateEmployeesGroup(10, PositionType.Design, SeniorityType.Senior));
        list.AddRange(itemFactory.CreateEmployeesGroup(20, PositionType.PM, SeniorityType.SemiSenior));
        list.AddRange(itemFactory.CreateEmployeesGroup(10, PositionType.PM, SeniorityType.Senior));
        list.Add(itemFactory.Create(PositionType.CEO, SeniorityType.Senior));

        return list;
    }
    
    public List<IEmployee> GenerateRandomEmployeesForTest()
    {
        var list = new List<IEmployee>();
        CreateEmployees create = new CreateEmployees();

        EmployeeFactory itemFactory = new EmployeeFactory();
        itemFactory.Init();

        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.HR, SeniorityType.Junior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.HR, SeniorityType.SemiSenior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.HR, SeniorityType.Senior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.Engineering, SeniorityType.Junior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.Engineering, SeniorityType.SemiSenior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.Engineering, SeniorityType.Senior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.Artist, SeniorityType.SemiSenior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.Artist, SeniorityType.Senior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.Design, SeniorityType.Junior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.Design, SeniorityType.Senior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.PM, SeniorityType.SemiSenior));
        list.AddRange(itemFactory.CreateEmployeesGroup(Random.Range(0, 45), PositionType.PM, SeniorityType.Senior));
        list.Add(itemFactory.Create(PositionType.CEO, SeniorityType.Senior));

        return list;
    }
}
