using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SalaryPercentageData
{
    public PositionType position;
    public SeniorityType seniority;
    public float salaryValue;
}

[CreateAssetMenu(menuName = "Employees/Salary Percentages")]
public class SalaryPercentageConfiguration : ScriptableObject
{
    [SerializeField] List<SalaryPercentageData> percentageList = new List<SalaryPercentageData>();

    public float GetSalaryPercentage(PositionType position, SeniorityType seniority)
    {
        var key = position.ToString() + seniority.ToString();
        foreach (var data in percentageList)
        {
            if (data.position == position && data.seniority == seniority)
            {
                return data.salaryValue;
            }
        }

        return 0;
    }
}