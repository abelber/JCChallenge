using System.Collections.Generic;

public class CreateEmployees
{
    public List<IEmployee> CreateEmployee(int quantity, string name, float baseSalary, IPosition position, ISeniority seniority, float salaryPercentage)
    {
        var list = new List<IEmployee>();
        for (int i = 0; i < quantity; i++)
        {
            IEmployee employee = new Employee(name, baseSalary, position, seniority, salaryPercentage);
            list.Add(employee);
        }

        return list;
    }
}
