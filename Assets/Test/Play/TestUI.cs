using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestUI
{
    private ListManagerView listManager;
    private ListManagerController listManagerController;

    [SetUp]
    public void Setup()
    {
        var listObject = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/ListPanel"));
        listManagerController = listObject.GetComponent<ListManagerController>();
        listManager = listObject.GetComponent<ListManagerView>();
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestUIListManager()
    {
        Assert.IsNotNull(listManagerController);
        Assert.IsNotNull(listManagerController.rowList);
    }

    [Test]
    public void TestUIInfoRow()
    {
        GenerateChallengeList();

        var infoRow = listManagerController.rowList[0].GetComponent<InfoRow>();
        Assert.IsNotNull(infoRow);
    }

    [Test]
    public void TestUIChallengeListButton()
    {
        GenerateChallengeList();

        Assert.AreEqual(251, listManagerController.rowList.Count);
    }

    [Test]
    public void TestUIRandomListButton()
    {
        listManagerController.Init();
        listManager.GenerateRandomListButton();

        Assert.Greater(listManagerController.rowList.Count, 0);
    }

    [Test]
    public void TestUIOrderByPositionButton()
    {
        GenerateChallengeList();

        listManager.OrderByPositionButton();
        var rowList = listManagerController.rowList;

        Assert.AreEqual(PositionType.HR, rowList[0].GetComponent<InfoRow>().employee.position.Position);
        Assert.AreEqual(PositionType.CEO, rowList[listManagerController.rowList.Count - 1].GetComponent<InfoRow>().employee.position.Position);
    }

    [Test]
    public void TestUIOrderBySeniorityButton()
    {
        GenerateChallengeList();

        listManager.OrderBySeniorityButton();
        var rowList = listManagerController.rowList;

        Assert.AreEqual(SeniorityType.Junior, rowList[0].GetComponent<InfoRow>().employee.seniority.Seniority);
        Assert.AreEqual(SeniorityType.Senior, rowList[listManagerController.rowList.Count - 1].GetComponent<InfoRow>().employee.seniority.Seniority);
    }

    [Test]
    public void TestUIApplyIncrementToAllButton()
    {
        GenerateChallengeList();

        var rowList = listManagerController.rowList;

        IApplyPercentToAll apply = new ApplyPercentToInfoRowsUI();
        apply.ApplyPercentageToAllRows(listManagerController);

        Assert.Greater(rowList[0].GetComponent<InfoRow>().employee.currentSalary, rowList[0].GetComponent<InfoRow>().employee.baseSalary.BaseSalary);
    }

    private void GenerateChallengeList()
    {
        listManagerController.Init();
        listManager.GenerateChallengeListButton();
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestUIWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.

        yield return null;
    }
}