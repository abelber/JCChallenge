using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestSalaryIncrement
{
    IEmployeesList employeesList;
    IApplyIncrementToRow applyIncrement;

    [SetUp]
    public void Setup()
    {
        employeesList = new EmployeesList();// Substitute.For<IEmployeesList>();
        List<IEmployee> list = new List<IEmployee>();

        CreateEmployessGenerationTest create = new CreateEmployessGenerationTest();
        list = create.GenerateEmployeesForTest();

        employeesList.InitList(list);

        applyIncrement = new ApplyIncrementToRow();
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestSalaryIncrementHR()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.HR)
            {
                float expectedResult = 0;

                switch (employee.seniority.Seniority)
                {
                    case SeniorityType.Junior:
                        {
                            expectedResult = 500 + ((500 * 0.5f)/100);
                            break;
                        }
                    case SeniorityType.SemiSenior:
                        {
                            expectedResult = 1000 + ((1000 * 2f) / 100);
                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 1500 + ((1500 * 5f) / 100);
                            break;
                        }
                }

                var result = applyIncrement.ApplyPercentageToRow(employee);

                CheckResult(expectedResult, result, employee);
            }
        }
    }

    [Test]
    public void TestSalaryIncrementEngineering()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.Engineering)
            {
                float expectedResult = 0;

                switch (employee.seniority.Seniority)
                {
                    case SeniorityType.Junior:
                        {
                            expectedResult = 1500 + ((1500 * 5f) / 100);
                            break;
                        }
                    case SeniorityType.SemiSenior:
                        {
                            expectedResult = 3000 + ((3000 * 7f) / 100);
                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 5000 + ((5000 * 10f) / 100);
                            break;
                        }
                }

                var result = applyIncrement.ApplyPercentageToRow(employee);

                CheckResult(expectedResult, result, employee);
            }
        }
    }

    [Test]
    public void TestSalaryIncrementArtist()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.Artist)
            {
                float expectedResult = 0;

                switch (employee.seniority.Seniority)
                {
                    case SeniorityType.SemiSenior:
                        {
                            expectedResult = 1200 + ((1200 * 2.5f) / 100);
                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 2000 + ((2000 * 5f) / 100);
                            break;
                        }
                }

                var result = applyIncrement.ApplyPercentageToRow(employee);

                CheckResult(expectedResult, result, employee);
            }
        }
    }

    [Test]
    public void TestSalaryIncrementDesign()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.Design)
            {
                float expectedResult = 0;

                switch (employee.seniority.Seniority)
                {
                    case SeniorityType.Junior:
                        {
                            expectedResult = 800 + ((800 * 4f) / 100);
                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 2000 + ((2000 * 7f) / 100);
                            break;
                        }
                }

                var result = applyIncrement.ApplyPercentageToRow(employee);

                CheckResult(expectedResult, result, employee);
            }
        }
    }

    [Test]
    public void TestSalaryIncrementPM()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.PM)
            {
                float expectedResult = 0;

                switch (employee.seniority.Seniority)
                {
                    case SeniorityType.SemiSenior:
                        {
                            expectedResult = 2400 + ((2400 * 5f) / 100);
                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 4000 + ((4000 * 10f) / 100);
                            break;
                        }
                }

                var result = applyIncrement.ApplyPercentageToRow(employee);

                CheckResult(expectedResult, result, employee);
            }
        }
    }

    [Test]
    public void TestSalaryIncrementCEO()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.CEO)
            {
                float expectedResult = 20000 + ((20000 * 100f) / 100);

                var result = applyIncrement.ApplyPercentageToRow(employee);

                CheckResult(expectedResult, result, employee);
            }
        }
    }

    private void CheckResult(float expectedResult, float result, IEmployee employee)
    {
        Debug.Log(employee.position.Position.ToString() + " - " + employee.seniority.Seniority.ToString() + " / Salary Increment: " + result);
        Assert.AreEqual(expectedResult, result);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestSalaryIncrementWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
