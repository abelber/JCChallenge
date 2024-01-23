using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class EmployeeFactory
{
    private Dictionary<string, IEmployee> employessDictionary;
    [SerializeField] BaseSalaryConfiguration baseSalaryConfig;
    [SerializeField] SalaryPercentageConfiguration salaryPercentageConfig;

    public void Init()
    {
        employessDictionary = new Dictionary<string, IEmployee>();
        var employees = Assembly.GetAssembly(typeof(IEmployee)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(IEmployee)));

        baseSalaryConfig = (BaseSalaryConfiguration)Resources.Load("Configs/BasySalaryConfig");
        salaryPercentageConfig = (SalaryPercentageConfiguration)Resources.Load("Configs/SalaryPercentageConfig");

        CreateEmployees(employessDictionary);
    }

    private Dictionary<string, IEmployee> CreateEmployees(Dictionary<string, IEmployee> _employessDictionary)
    {
        _employessDictionary.Add(PositionType.HR.ToString() + SeniorityType.Junior.ToString(), new Employee("Name JR", baseSalaryConfig.GetBaseSalary(PositionType.HR, SeniorityType.Junior), new PositionHR(), new SeniorityJunior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.HR, SeniorityType.Junior)));
        _employessDictionary.Add(PositionType.HR.ToString() + SeniorityType.SemiSenior.ToString(), new Employee("Name SSr", baseSalaryConfig.GetBaseSalary(PositionType.HR, SeniorityType.SemiSenior), new PositionHR(), new SenioritySemiSenior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.HR, SeniorityType.SemiSenior)));
        _employessDictionary.Add(PositionType.HR.ToString() + SeniorityType.Senior.ToString(), new Employee("Name Sr", baseSalaryConfig.GetBaseSalary(PositionType.HR, SeniorityType.Senior), new PositionHR(), new SenioritySenior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.HR, SeniorityType.Senior)));
        _employessDictionary.Add(PositionType.Engineering.ToString() + SeniorityType.Junior.ToString(), new Employee("Name Jr", baseSalaryConfig.GetBaseSalary(PositionType.Engineering, SeniorityType.Junior), new PositionEngineering(), new SeniorityJunior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.Engineering, SeniorityType.Junior)));
        _employessDictionary.Add(PositionType.Engineering.ToString() + SeniorityType.SemiSenior.ToString(), new Employee("Name SSr", baseSalaryConfig.GetBaseSalary(PositionType.Engineering, SeniorityType.SemiSenior), new PositionEngineering(), new SenioritySemiSenior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.Engineering, SeniorityType.SemiSenior)));
        _employessDictionary.Add(PositionType.Engineering.ToString() + SeniorityType.Senior.ToString(), new Employee("Name Sr", baseSalaryConfig.GetBaseSalary(PositionType.Engineering, SeniorityType.Senior), new PositionEngineering(), new SenioritySenior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.Engineering, SeniorityType.Senior)));
        _employessDictionary.Add(PositionType.Artist.ToString() + SeniorityType.SemiSenior.ToString(), new Employee("Name SSr", baseSalaryConfig.GetBaseSalary(PositionType.Artist, SeniorityType.SemiSenior), new PositionArtist(), new SenioritySemiSenior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.Artist, SeniorityType.SemiSenior)));
        _employessDictionary.Add(PositionType.Artist.ToString() + SeniorityType.Senior.ToString(), new Employee("Name Sr", baseSalaryConfig.GetBaseSalary(PositionType.Artist, SeniorityType.Senior), new PositionArtist(), new SenioritySenior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.Artist, SeniorityType.Senior)));
        _employessDictionary.Add(PositionType.Design.ToString() + SeniorityType.Junior.ToString(), new Employee("Name Jr", baseSalaryConfig.GetBaseSalary(PositionType.Design, SeniorityType.Junior), new PositionDesign(), new SeniorityJunior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.Design, SeniorityType.Junior)));
        _employessDictionary.Add(PositionType.Design.ToString() + SeniorityType.Senior.ToString(), new Employee("Name Sr", baseSalaryConfig.GetBaseSalary(PositionType.Design, SeniorityType.Senior), new PositionDesign(), new SenioritySenior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.Design, SeniorityType.Senior)));
        _employessDictionary.Add(PositionType.PM.ToString() + SeniorityType.SemiSenior.ToString(), new Employee("Name SSr", baseSalaryConfig.GetBaseSalary(PositionType.PM, SeniorityType.SemiSenior), new PositionPM(), new SenioritySemiSenior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.PM, SeniorityType.SemiSenior)));
        _employessDictionary.Add(PositionType.PM.ToString() + SeniorityType.Senior.ToString(), new Employee("Name Sr", baseSalaryConfig.GetBaseSalary(PositionType.PM, SeniorityType.Senior), new PositionPM(), new SenioritySenior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.PM, SeniorityType.Senior)));
        _employessDictionary.Add(PositionType.CEO.ToString() + SeniorityType.Senior.ToString(), new Employee("Name CEO", baseSalaryConfig.GetBaseSalary(PositionType.CEO, SeniorityType.Senior), new PositionCEO(), new SenioritySenior(), salaryPercentageConfig.GetSalaryPercentage(PositionType.CEO, SeniorityType.Senior)));

        return _employessDictionary;
    }

    public IEmployee Create(PositionType position, SeniorityType seniority)
    {
        string key = position.ToString() + seniority.ToString();
        if (employessDictionary.ContainsKey(key))
        {
            var temp = employessDictionary[key];
            IEmployee employee = new Employee(temp.name, temp.baseSalary, temp.position, temp.seniority, temp.salaryPercentage);
            return employee;
        }

        return null;
    }

    public List<IEmployee> CreateEmployeesGroup(int quantity, PositionType position, SeniorityType seniority)
    {
        var list = new List<IEmployee>();
        for (int i = 0; i < quantity; i++)
        {
            IEmployee employee = Create(position, seniority);
            list.Add(employee);
        }

        return list;
    }
}
