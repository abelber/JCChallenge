using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SeniorityCount : MonoBehaviour
{
    public GameObject textPrefab;

    private void CreateSeniorityTotalUI(PositionType positionType, SeniorityType seniorityType, int total)
    {
        var positionText = Instantiate(textPrefab, transform).GetComponent<TextMeshProUGUI>();
        positionText.text = positionType.ToString() + " - " + seniorityType.ToString() + ": " + total.ToString();
    }

    public void ShowUI(IEmployeesList employeesList)
    {
        ClearUI();

        SenioritiesTotal senioritiesTotal = new SenioritiesTotal();

        CreateSeniorityTotalUI(PositionType.HR, SeniorityType.Junior, senioritiesTotal.GetSeniorityTotal(PositionType.HR, SeniorityType.Junior, employeesList));
        CreateSeniorityTotalUI(PositionType.HR, SeniorityType.SemiSenior, senioritiesTotal.GetSeniorityTotal(PositionType.HR, SeniorityType.SemiSenior, employeesList));
        CreateSeniorityTotalUI(PositionType.HR, SeniorityType.Senior, senioritiesTotal.GetSeniorityTotal(PositionType.HR, SeniorityType.Senior, employeesList));
        CreateSeniorityTotalUI(PositionType.Artist, SeniorityType.SemiSenior, senioritiesTotal.GetSeniorityTotal(PositionType.Artist, SeniorityType.SemiSenior, employeesList));
        CreateSeniorityTotalUI(PositionType.Artist, SeniorityType.Senior, senioritiesTotal.GetSeniorityTotal(PositionType.Artist, SeniorityType.Senior, employeesList));
        CreateSeniorityTotalUI(PositionType.Engineering, SeniorityType.Junior, senioritiesTotal.GetSeniorityTotal(PositionType.Engineering, SeniorityType.Junior, employeesList));
        CreateSeniorityTotalUI(PositionType.Engineering, SeniorityType.SemiSenior, senioritiesTotal.GetSeniorityTotal(PositionType.Engineering, SeniorityType.SemiSenior, employeesList));
        CreateSeniorityTotalUI(PositionType.Engineering, SeniorityType.Senior, senioritiesTotal.GetSeniorityTotal(PositionType.Engineering, SeniorityType.Senior, employeesList));
        CreateSeniorityTotalUI(PositionType.Design, SeniorityType.Junior, senioritiesTotal.GetSeniorityTotal(PositionType.Design, SeniorityType.Junior, employeesList));
        CreateSeniorityTotalUI(PositionType.Design, SeniorityType.Senior, senioritiesTotal.GetSeniorityTotal(PositionType.Design, SeniorityType.Senior, employeesList));
        CreateSeniorityTotalUI(PositionType.PM, SeniorityType.SemiSenior, senioritiesTotal.GetSeniorityTotal(PositionType.PM, SeniorityType.SemiSenior, employeesList));
        CreateSeniorityTotalUI(PositionType.PM, SeniorityType.Senior, senioritiesTotal.GetSeniorityTotal(PositionType.PM, SeniorityType.Senior, employeesList));
        CreateSeniorityTotalUI(PositionType.CEO, SeniorityType.Senior, senioritiesTotal.GetSeniorityTotal(PositionType.CEO, SeniorityType.Senior, employeesList));
    }

    private void ClearUI()
    {
        var childs = transform.childCount;
        for (int i = 0; i < childs; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
