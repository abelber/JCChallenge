using System.Collections.Generic;

public interface IEmployeesList
{
    List<IEmployee> employeesList { get; set; }
    void InitList(List<IEmployee> employees);
}

public class EmployeesList : IEmployeesList
{
    public List<IEmployee> employeesList { get; set; }

    public EmployeesList()
    {
        employeesList = new List<IEmployee>();
    }

    public void InitList(List<IEmployee> employees)
    {
        employeesList = employees;
    }
}
