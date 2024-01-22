using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public interface IEmployeesListSort
{
    void SortByPosition(IEmployeesList list);
    void SortBySeniority(IEmployeesList list);
}

public class EmployeesListSort : IEmployeesListSort
{
    public void SortByPosition(IEmployeesList list)
    {
        list.employeesList = list.employeesList.OrderBy(x => x.position.Position).ToList();
    }

    public void SortBySeniority(IEmployeesList list)
    {
        list.employeesList = list.employeesList.OrderBy(x => x.seniority.Seniority).ToList();
    }
}
