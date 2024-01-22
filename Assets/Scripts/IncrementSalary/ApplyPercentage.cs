using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyPercentage : MonoBehaviour
{
    InfoRow infoRow;

    void Start()
    {
        infoRow = transform.parent.GetComponent<InfoRow>();
    }

    public void ApplyButton()
    {
        IApplyIncrementToRow applyIncrementToRow = new ApplyIncrementToRow();
        applyIncrementToRow.ApplyPercentageToRow(infoRow.employee);
        infoRow.RefreshData();
    }
}
