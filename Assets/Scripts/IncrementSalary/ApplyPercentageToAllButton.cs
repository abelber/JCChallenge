using UnityEngine;

public class ApplyPercentageToAllButton : MonoBehaviour
{
    public void ApplyToAllButton(ListManager listManager)
    {
        IApplyPercentToAll applyPercent = new ApplyPercentToInfoRowsUI();
        applyPercent.ApplyPercentageToAllRows(listManager);
    }
}