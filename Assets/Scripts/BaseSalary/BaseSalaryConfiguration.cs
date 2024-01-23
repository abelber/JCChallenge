using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Employees/Base Salary")]
public class BaseSalaryConfiguration : ScriptableObject
{
    [SerializeField] float SalaryBaseSalaryArtistSemiSenior;
    [SerializeField] float SalaryBaseSalaryArtistSenior;
    [SerializeField] float SalaryBaseSalaryCEO;
    [SerializeField] float SalaryBaseSalaryDesignJunior;
    [SerializeField] float SalaryBaseSalaryDesignSenior;
    [SerializeField] float SalaryBaseSalaryEngineeringJunior;
    [SerializeField] float SalaryBaseSalaryEngineeringSemiSenior;
    [SerializeField] float SalaryBaseSalaryEngineeringSenior;
    [SerializeField] float SalaryBaseSalaryHRJunior;
    [SerializeField] float SalaryBaseSalaryHRSemiSenior;
    [SerializeField] float SalaryBaseSalaryHRSenior;
    [SerializeField] float SalaryBaseSalaryPMSemiSenior;
    [SerializeField] float SalaryBaseSalaryPMSenior;

    private void Awake()
    {
    }
}
