using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseSalaryData
{
    public PositionType position;
    public SeniorityType seniority;
    public float salaryValue;
}

[CreateAssetMenu(menuName = "Employees/Base Salary")]
public class BaseSalaryConfiguration : ScriptableObject
{
    [SerializeField] List<BaseSalaryData> baseSalaryList = new List<BaseSalaryData>();

    public float GetBaseSalary(PositionType position, SeniorityType seniority)
    {
        var key = position.ToString() + seniority.ToString();
        foreach(var data in baseSalaryList)
        {
            if(data.position == position && data.seniority == seniority)
            {
                    return data.salaryValue;
            }
        }

        return 0;
    }
}
