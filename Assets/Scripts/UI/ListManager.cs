using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListManager : MonoBehaviour
{
    public List<GameObject> rowList;
    public Transform listElementsContainer;
    public GameObject listElementPrefab;
    public PositionsCount positionsPanel;
    public SeniorityCount seniorityCount;

    IEmployeesList employeesListInstance;
    IEmployeesListSort employeesListSortInstance;

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

    private void PopulateList()
    {
        foreach(var employe in employeesListInstance.employeesList)
        {
            var element = Instantiate(listElementPrefab, listElementsContainer).GetComponent<InfoRow>();
            element.Init(employe);

            rowList.Add(element.gameObject);
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

    private void GenerateEmployeesUI(IEmployeesList employeesList)
    {
        CleanList();
        PopulateList();
        positionsPanel.ShowUI(employeesList);
        seniorityCount.ShowUI(employeesList);
    }

    public void GenerateChallengeListButton()
    {
        CreateEmployessGenerationTest create = new CreateEmployessGenerationTest();
        employeesListInstance.employeesList = create.GenerateEmployeesForTest();

        employeesListSortInstance.SortBySeniority(employeesListInstance);
        employeesListSortInstance.SortByPosition(employeesListInstance);

        GenerateEmployeesUI(employeesListInstance);
    }

    public void GenerateRandomListButton()
    {
        CreateEmployessGenerationTest create = new CreateEmployessGenerationTest();
        employeesListInstance.employeesList = create.GenerateRandomEmployeesForTest();

        employeesListSortInstance.SortBySeniority(employeesListInstance);
        employeesListSortInstance.SortByPosition(employeesListInstance);

        GenerateEmployeesUI(employeesListInstance);
    }

    public void OrderByPositionButton()
    {
        employeesListSortInstance.SortByPosition(employeesListInstance);
        GenerateEmployeesUI(employeesListInstance);
    }

    public void OrderBySeniorityButton()
    {
        employeesListSortInstance.SortBySeniority(employeesListInstance);
        GenerateEmployeesUI(employeesListInstance);
    }    
}
