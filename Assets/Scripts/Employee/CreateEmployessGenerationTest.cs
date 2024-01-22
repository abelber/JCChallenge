using System.Collections.Generic;
using UnityEngine;

public class CreateEmployessGenerationTest
{
    public List<IEmployee> GenerateEmployeesForTest()
    {
        var list = new List<IEmployee>();
        CreateEmployees create = new CreateEmployees();

        list.AddRange(create.CreateEmployee(13, "Name JR", new BaseSalaryHRJunior(), new PositionHR(), new SeniorityJunior(), new SalaryPercentHRJunior()));
        list.AddRange(create.CreateEmployee(2, "Name SSr", new BaseSalaryHRSemiSenior(), new PositionHR(), new SenioritySemiSenior(), new SalaryPercentHRSemiSenior()));
        list.AddRange(create.CreateEmployee(5, "Name Sr", new BaseSalaryHRSenior(), new PositionHR(), new SenioritySenior(), new SalaryPercentHRSenior()));
        list.AddRange(create.CreateEmployee(32, "Name Jr", new BaseSalaryEngineeringJunior(), new PositionEngineering(), new SeniorityJunior(), new SalaryPercentEngineeringJunior()));
        list.AddRange(create.CreateEmployee(68, "Name SSr", new BaseSalaryEngineeringSemiSenior(), new PositionEngineering(), new SenioritySemiSenior(), new SalaryPercentEngineeringSemiSenior()));
        list.AddRange(create.CreateEmployee(50, "Name Sr", new BaseSalaryEngineeringSenior(), new PositionEngineering(), new SenioritySenior(), new SalaryPercentEngineeringSenior()));
        list.AddRange(create.CreateEmployee(20, "Name SSr", new BaseSalaryArtistSemiSenior(), new PositionArtist(), new SenioritySemiSenior(), new SalaryPercentArtistSemiSenior()));
        list.AddRange(create.CreateEmployee(5, "Name Sr", new BaseSalaryArtistSenior(), new PositionArtist(), new SenioritySenior(), new SalaryPercentArtistSenior()));
        list.AddRange(create.CreateEmployee(15, "Name Jr", new BaseSalaryDesignJunior(), new PositionDesign(), new SeniorityJunior(), new SalaryPercentDesignJunior()));
        list.AddRange(create.CreateEmployee(10, "Name Sr", new BaseSalaryDesignSenior(), new PositionDesign(), new SenioritySenior(), new SalaryPercentDesignSenior()));
        list.AddRange(create.CreateEmployee(20, "Name SSr", new BaseSalaryPMSemiSenior(), new PositionPM(), new SenioritySemiSenior(), new SalaryPercentPMSemiSenior()));
        list.AddRange(create.CreateEmployee(10, "Name Sr", new BaseSalaryPMSenior(), new PositionPM(), new SenioritySenior(), new SalaryPercentPMSenior()));
        list.Add(new Employee("Name CEO", new BaseSalaryCEO(), new PositionCEO(), new SenioritySenior(), new SalaryPercentCEO()));

        return list;
    }

    public List<IEmployee> GenerateRandomEmployeesForTest()
    {
        var list = new List<IEmployee>();
        CreateEmployees create = new CreateEmployees();

        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name JR", new BaseSalaryHRJunior(), new PositionHR(), new SeniorityJunior(), new SalaryPercentHRJunior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name SSr", new BaseSalaryHRSemiSenior(), new PositionHR(), new SenioritySemiSenior(), new SalaryPercentHRSemiSenior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name Sr", new BaseSalaryHRSenior(), new PositionHR(), new SenioritySenior(), new SalaryPercentHRSenior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name Jr", new BaseSalaryEngineeringJunior(), new PositionEngineering(), new SeniorityJunior(), new SalaryPercentEngineeringJunior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name SSr", new BaseSalaryEngineeringSemiSenior(), new PositionEngineering(), new SenioritySemiSenior(), new SalaryPercentEngineeringSemiSenior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name Sr", new BaseSalaryEngineeringSenior(), new PositionEngineering(), new SenioritySenior(), new SalaryPercentEngineeringSenior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name SSr", new BaseSalaryArtistSemiSenior(), new PositionArtist(), new SenioritySemiSenior(), new SalaryPercentArtistSemiSenior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name Sr", new BaseSalaryArtistSenior(), new PositionArtist(), new SenioritySenior(), new SalaryPercentArtistSenior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name Jr", new BaseSalaryDesignJunior(), new PositionDesign(), new SeniorityJunior(), new SalaryPercentDesignJunior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name Sr", new BaseSalaryDesignSenior(), new PositionDesign(), new SenioritySenior(), new SalaryPercentDesignSenior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name SSr", new BaseSalaryPMSemiSenior(), new PositionPM(), new SenioritySemiSenior(), new SalaryPercentPMSemiSenior()));
        list.AddRange(create.CreateEmployee(Random.Range(0, 45), "Name Sr", new BaseSalaryPMSenior(), new PositionPM(), new SenioritySenior(), new SalaryPercentPMSenior()));
        list.Add(new Employee("Name CEO", new BaseSalaryCEO(), new PositionCEO(), new SenioritySenior(), new SalaryPercentCEO()));

        return list;
    }
}
