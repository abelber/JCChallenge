using UnityEngine;

public class ApplyPercentageToAllButton : MonoBehaviour
{
    public void ApplyToAllButton(ListManagerController listManagerController)
    {
        IApplyPercentToAll applyPercent = new ApplyPercentToInfoRowsUI();
        applyPercent.ApplyPercentageToAllRows(listManagerController);
    }
}