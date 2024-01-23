using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListManagerController : MonoBehaviour
{
    public List<GameObject> rowList;
    IEmployeesList employeesListInstance;
    IEmployeesListSort employeesListSortInstance;
    [SerializeField] ListManagerView listManagerView;

    void Start()
    {
        Init();
    }

    public void Init()
    {
        employeesListInstance = new EmployeesList();
        employeesListSortInstance = new EmployeesListSort();
        rowList = new List<GameObject>();
    }

    private void PopulateList(IEmployeesList employeesList)
    {
        foreach (var employee in employeesList.employeesList)
        {
            var rowObject = listManagerView.CreateRowItem(employee);
            rowList.Add(rowObject);
        }
    }

    private void CleanList()
    {
        foreach (var row in rowList)
        {
            Destroy(row);
        }

        rowList.Clear();
    }

    public void GenerateChallengeList()
    {
        CreateEmployessGenerationTest create = new CreateEmployessGenerationTest();
        employeesListInstance.employeesList = create.GenerateEmployeesForTest();

        employeesListSortInstance.SortBySeniority(employeesListInstance);
        employeesListSortInstance.SortByPosition(employeesListInstance);

        CleanList();
        PopulateList(employeesListInstance);

        listManagerView.GenerateEmployeesUI(employeesListInstance);
    }

    public void GenerateRandomList()
    {
        CreateEmployessGenerationTest create = new CreateEmployessGenerationTest();
        employeesListInstance.employeesList = create.GenerateRandomEmployeesForTest();

        employeesListSortInstance.SortBySeniority(employeesListInstance);
        employeesListSortInstance.SortByPosition(employeesListInstance);

        CleanList();
        PopulateList(employeesListInstance);

        listManagerView.GenerateEmployeesUI(employeesListInstance);
    }

    public void OrderByPosition()
    {
        employeesListSortInstance.SortByPosition(employeesListInstance);

        CleanList();
        PopulateList(employeesListInstance);

        listManagerView.GenerateEmployeesUI(employeesListInstance);
    }

    public void OrderBySeniority()
    {
        employeesListSortInstance.SortBySeniority(employeesListInstance);

        CleanList();
        PopulateList(employeesListInstance);

        listManagerView.GenerateEmployeesUI(employeesListInstance);
    }
}
