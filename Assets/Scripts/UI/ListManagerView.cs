using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListManagerView : MonoBehaviour
{
    public GameObject listElementPrefab;
    public Transform listElementsContainer;
    public PositionsCount positionsPanel;
    public SeniorityCount seniorityPanel;
    [SerializeField] ListManagerController listManagerController;

    public GameObject CreateRowItem(IEmployee employee)
    {
        var element = Instantiate(listElementPrefab, listElementsContainer).GetComponent<InfoRow>();
        element.Init(employee);

        return element.gameObject;
    }

    public void GenerateEmployeesUI(IEmployeesList employeesList)
    {
        positionsPanel.ShowUI(employeesList);
        seniorityPanel.ShowUI(employeesList);
    }

    public void GenerateChallengeListButton()
    {
        listManagerController.GenerateChallengeList();
    }

    public void GenerateRandomListButton()
    {
        listManagerController.GenerateRandomList();
    }

    public void OrderByPositionButton()
    {
        listManagerController.OrderByPosition();
    }

    public void OrderBySeniorityButton()
    {
        listManagerController.OrderBySeniority();
    }    
}
