using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoRow : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI positionText;
    public TextMeshProUGUI seniorityText;
    public TextMeshProUGUI baseSalaryText;
    public IEmployee employee;

    public void Init(IEmployee _employee)
    {
        employee = _employee;

        RefreshData();
    }

    public void RefreshData()
    {
        nameText.text = employee.name;
        positionText.text = employee.position.Position.ToString();
        seniorityText.text = employee.seniority.Seniority.ToString();
        baseSalaryText.text = employee.currentSalary.ToString();
    }
}
