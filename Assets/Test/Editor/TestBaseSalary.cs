using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestBaseSalary
{
    IEmployeesList employeesList;

    [SetUp]
    public void Setup()
    {
        employeesList = new EmployeesList();// Substitute.For<IEmployeesList>();
        List<IEmployee> list = new List<IEmployee>();

        CreateEmployessGenerationTest create = new CreateEmployessGenerationTest();
        list = create.GenerateEmployeesForTest();

        employeesList.InitList(list);
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestBaseSalaryHR()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.HR)
            {
                var expectedResult = 0f;
                switch (employee.seniority.Seniority)
                {
                    case SeniorityType.Junior:
                        {
                            expectedResult = 500f;

                            break;
                        }
                    case SeniorityType.SemiSenior:
                        {
                            expectedResult = 1000f;

                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 1500f;
                            break;
                        }
                }

                CheckResult(expectedResult, employee);
            }
        }
    }

    [Test]
    public void TestBaseSalaryEngineering()
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
                            expectedResult = 1500f;

                            break;
                        }
                    case SeniorityType.SemiSenior:
                        {
                            expectedResult = 3000f;

                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 5000f;

                            break;
                        }
                }

                CheckResult(expectedResult, employee);
            }
        }
    }

    [Test]
    public void TestBaseSalaryArtist()
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
                            expectedResult = 1200f;

                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 2000f;

                            break;
                        }
                }

                CheckResult(expectedResult, employee);
            }
        }
    }

    [Test]
    public void TestBaseSalaryDesign()
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
                            expectedResult = 800f;

                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 2000f;

                            break;
                        }
                }

                CheckResult(expectedResult, employee);
            }
        }
    }

    [Test]
    public void TestBaseSalaryPM()
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
                            expectedResult = 2400f;

                            break;
                        }
                    case SeniorityType.Senior:
                        {
                            expectedResult = 4000f;

                            break;
                        }
                }

                CheckResult(expectedResult, employee);
            }
        }
    }

    [Test]
    public void TestBaseSalaryCEO()
    {
        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == PositionType.CEO)
            {
                var expectedResult = 20000f;

                CheckResult(expectedResult, employee);
            }
        }
    }

    private void CheckResult(float expectedResult, IEmployee employee)
    {
        Debug.Log(employee.position.Position.ToString() + " - " + employee.seniority.Seniority.ToString() + " / Base Salary: " + employee.baseSalary.ToString());
        Assert.AreEqual(expectedResult, employee.baseSalary);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestBaseSalaryWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}