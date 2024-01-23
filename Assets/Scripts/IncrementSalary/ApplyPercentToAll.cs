public interface IApplyPercentToAll
{
    void ApplyPercentageToAllRows(ListManagerController listManagerController);
}

public class ApplyPercentToInfoRowsUI : IApplyPercentToAll
{
    public void ApplyPercentageToAllRows(ListManagerController listManagerController)
    {
        foreach (var row in listManagerController.rowList)
        {
            var infoRow = row.GetComponent<InfoRow>();

            if (infoRow != null)
            {
                IApplyIncrementToRow applyPercentage = new ApplyIncrementToRow();
                applyPercentage.ApplyPercentageToRow(infoRow.employee);
                infoRow.RefreshData();
            }
        }
    }
}
