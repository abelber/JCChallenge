using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestSalaryPercentage
{
    private IEmployeesList employeesList;

    [SetUp]
    public void Setup()
    {
        employeesList = new EmployeesList(); //Substitute.For<IEmployeesList>();
        List<IEmployee> list = new List<IEmployee>();

        CreateEmployessGenerationTest create = new CreateEmployessGenerationTest();
        list = create.GenerateEmployeesForTest();

        employeesList.InitList(list);
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestSalaryPercentageHR()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.HR)
            {
                var expectedResult = 0f;
                switch(employee.seniority.Seniority)
                {
                    case SeniorityType.Junior:
                        {
                            expectedResult = 0.5f;

                            break;
                        }
                    case SeniorityType.SemiSenior:
                        {
                            expectedResult = 2f;

                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 5f;

                            break;
                        }
                }

                CheckResult(expectedResult, employee);
            }
        }
    }

    [Test]
    public void TestSalaryPercentageEngineering()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.Engineering)
            {
                var expectedResult = 0f;
                switch (employee.seniority.Seniority)
                {
                    case SeniorityType.Junior:
                        {
                            expectedResult = 5f;

                            break;
                        }
                    case SeniorityType.SemiSenior:
                        {
                            expectedResult = 7f;

                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 10f;

                            break;
                        }
                }

                CheckResult(expectedResult, employee);
            }
        }
    }

    [Test]
    public void TestSalaryPercentageArtist()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.Artist)
            {
                var expectedResult = 0f;
                switch (employee.seniority.Seniority)
                {
                    case SeniorityType.SemiSenior:
                        {
                            expectedResult = 2.5f;

                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 5f;

                            break;
                        }
                }

                CheckResult(expectedResult, employee);
            }
        }
    }

    [Test]
    public void TestSalaryPercentageDesign()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.Design)
            {
                var expectedResult = 0f;
                switch (employee.seniority.Seniority)
                {
                    case SeniorityType.Junior:
                        {
                            expectedResult = 4f;

                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 7f;

                            break;
                        }
                }

                CheckResult(expectedResult, employee);
            }
        }
    }

    [Test]
    public void TestSalaryPercentagePM()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.PM)
            {
                var expectedResult = 0f;
                switch (employee.seniority.Seniority)
                {
                    case SeniorityType.SemiSenior:
                        {
                            expectedResult = 5f;

                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 10f;

                            break;
                        }
                }

                CheckResult(expectedResult, employee);
            }
        }
    }

    [Test]
    public void TestSalaryPercentageCEO()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.CEO)
            {
                CheckResult(100f, employee);
            }
        }
    }

    private void CheckResult(float expectedResult, IEmployee employee)
    {
        Debug.Log(employee.position.Position.ToString() + " - " + employee.seniority.Seniority.ToString() + " / Salary Percentage: " + employee.salaryPercentage);
        Assert.AreEqual(expectedResult, employee.salaryPercentage);
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
