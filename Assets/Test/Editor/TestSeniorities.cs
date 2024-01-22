using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

public class TestSeniorities
{
    private IEmployeesList employeesList;
    SenioritiesTotal senioritiesTotal;

    [SetUp]
    public void Setup()
    {
        employeesList = new EmployeesList();// Substitute.For<IEmployeesList>();
        List<IEmployee> list = new List<IEmployee>();

        CreateEmployessGenerationTest create = new CreateEmployessGenerationTest();
        list = create.GenerateEmployeesForTest();

        employeesList.InitList(list);

        senioritiesTotal = new SenioritiesTotal();
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestSeniorityHRJunior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.HR, SeniorityType.Junior, employeesList);

        CheckResult(13, total, PositionType.HR, SeniorityType.Junior);
    }

    [Test]
    public void TestSeniorityHRSemiSenior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.HR, SeniorityType.SemiSenior, employeesList);

        CheckResult(2, total, PositionType.HR, SeniorityType.SemiSenior);
    }

    [Test]
    public void TestSeniorityHRSenior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.HR, SeniorityType.Senior, employeesList);

        CheckResult(5, total, PositionType.HR, SeniorityType.Senior);
    }

    [Test]
    public void TestSeniorityEngineeringJunior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.Engineering, SeniorityType.Junior, employeesList);

        CheckResult(32, total, PositionType.Engineering, SeniorityType.Junior);
    }

    [Test]
    public void TestSeniorityEngineeringSemiSenior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.Engineering, SeniorityType.SemiSenior, employeesList);

        CheckResult(68, total, PositionType.Engineering, SeniorityType.SemiSenior);
    }

    [Test]
    public void TestSeniorityEngineeringSenior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.Engineering, SeniorityType.Senior, employeesList);

        CheckResult(50, total, PositionType.Engineering, SeniorityType.Senior);
    }

    [Test]
    public void TestSeniorityArtistSemiSenior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.Artist, SeniorityType.SemiSenior, employeesList);

        CheckResult(20, total, PositionType.Artist, SeniorityType.SemiSenior);
    }

    [Test]
    public void TestSeniorityArtistSenior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.Artist, SeniorityType.Senior, employeesList);

        CheckResult(5, total, PositionType.Artist, SeniorityType.Senior);
    }

    [Test]
    public void TestSeniorityDesignJunior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.Design, SeniorityType.Junior, employeesList);

        CheckResult(15, total, PositionType.Design, SeniorityType.Junior);
    }

    [Test]
    public void TestSeniorityDesignSenior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.Design, SeniorityType.Senior, employeesList);

        CheckResult(10, total, PositionType.Design, SeniorityType.Senior);
    }

    [Test]
    public void TestSeniorityPMSemiSenior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.PM, SeniorityType.SemiSenior, employeesList);

        CheckResult(20, total, PositionType.PM, SeniorityType.SemiSenior);
    }

    [Test]
    public void TestSeniorityPMSenior()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.PM, SeniorityType.Senior, employeesList);

        CheckResult(10, total, PositionType.PM, SeniorityType.Senior);
    }

    [Test]
    public void TestSeniorityCEO()
    {
        int total = senioritiesTotal.GetSeniorityTotal(PositionType.CEO, SeniorityType.Senior, employeesList);

        CheckResult(1, total, PositionType.CEO, SeniorityType.Senior);
    }

    private void CheckResult(int expectedResult, int result, PositionType positionType, SeniorityType seniorityType)
    {
        Debug.Log(positionType + " - " + seniorityType + ": " + result.ToString());
        Assert.AreEqual(expectedResult, result);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestPositionsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
