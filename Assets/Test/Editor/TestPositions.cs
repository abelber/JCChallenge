using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

public class TestPositions
{
    private IEmployeesList employeesList;
    private PositionsTotal positionCount;

    [SetUp]
    public void Setup()
    {
        employeesList = new EmployeesList();// Substitute.For<IEmployeesList>();
        List<IEmployee> list = new List<IEmployee>();

        CreateEmployessGenerationTest create = new CreateEmployessGenerationTest();
        list = create.GenerateEmployeesForTest();

        employeesList.InitList(list);

        positionCount = new PositionsTotal();
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestPositionsHR()
    {
        int total = positionCount.GetPositionTotal(PositionType.HR, employeesList);

        CheckResult(20, total, PositionType.HR);
    }

    [Test]
    public void TestPositionsEngineering()
    {
        int total = positionCount.GetPositionTotal(PositionType.Engineering, employeesList);

        CheckResult(150, total, PositionType.Engineering);
    }

    [Test]
    public void TestPositionsArtist()
    {
        int total = positionCount.GetPositionTotal(PositionType.Artist, employeesList);

        CheckResult(25, total, PositionType.Artist);
    }

    [Test]
    public void TestPositionsDesign()
    {
        int total = positionCount.GetPositionTotal(PositionType.Design, employeesList);

        CheckResult(25, total, PositionType.Design);
    }

    [Test]
    public void TestPositionsPM()
    {
        int total = positionCount.GetPositionTotal(PositionType.PM, employeesList);

        CheckResult(30, total, PositionType.PM);
    }

    [Test]
    public void TestPositionsCEO()
    {
        int total = positionCount.GetPositionTotal(PositionType.CEO, employeesList);

        CheckResult(1, total, PositionType.CEO);
    }

    private void CheckResult(int expectedResult, int result, PositionType positionType)
    {
        Debug.Log(positionType.ToString() + " / Total: " + result.ToString());
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
