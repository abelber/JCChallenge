using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PositionsCount : MonoBehaviour
{
    public GameObject textPrefab;

    private void CreatePositionTotalUI(PositionType positionType, int total)
    {
        var positionText = Instantiate(textPrefab, transform).GetComponent<TextMeshProUGUI>();
        positionText.text = positionType.ToString() + ": " + total.ToString();
    }

    public void ShowUI(IEmployeesList employeesList)
    {
        ClearUI();

        PositionsTotal positionsTotal = new PositionsTotal();

        CreatePositionTotalUI(PositionType.HR, positionsTotal.GetPositionTotal(PositionType.HR, employeesList));
        CreatePositionTotalUI(PositionType.Artist, positionsTotal.GetPositionTotal(PositionType.Artist, employeesList));
        CreatePositionTotalUI(PositionType.Engineering, positionsTotal.GetPositionTotal(PositionType.Engineering, employeesList));
        CreatePositionTotalUI(PositionType.Design, positionsTotal.GetPositionTotal(PositionType.Design, employeesList));
        CreatePositionTotalUI(PositionType.PM, positionsTotal.GetPositionTotal(PositionType.PM, employeesList));
        CreatePositionTotalUI(PositionType.CEO, positionsTotal.GetPositionTotal(PositionType.CEO, employeesList));
    }

    private void ClearUI()
    {
        var childs = transform.childCount;
        for(int i = 0; i < childs; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
