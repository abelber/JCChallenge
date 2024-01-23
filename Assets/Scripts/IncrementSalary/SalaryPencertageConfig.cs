using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Employees/Salary Percentages")]
public class SalaryPercentageConfig : ScriptableObject
{
    [SerializeField] float SalaryPercentArtistSemiSenior;
    [SerializeField] float SalaryPercentArtistSenior;
    [SerializeField] float SalaryPercentCEO;
    [SerializeField] float SalaryPercentDesignJunior;
    [SerializeField] float SalaryPercentDesignSenior;
    [SerializeField] float SalaryPercentEngineeringJunior;
    [SerializeField] float SalaryPercentEngineeringSemiSenior;
    [SerializeField] float SalaryPercentEngineeringSenior;
    [SerializeField] float SalaryPercentHRJunior;
    [SerializeField] float SalaryPercentHRSemiSenior;
    [SerializeField] float SalaryPercentHRSenior;
    [SerializeField] float SalaryPercentPMSemiSenior;
    [SerializeField] float SalaryPercentPMSenior;

    private void Awake()
    {
    }
}
