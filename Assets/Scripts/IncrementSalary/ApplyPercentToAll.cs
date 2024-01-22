public interface IApplyPercentToAll
{
    void ApplyPercentageToAllRows(ListManager listManager);
}

public class ApplyPercentToInfoRowsUI : IApplyPercentToAll
{
    public void ApplyPercentageToAllRows(ListManager listManager)
    {
        foreach (var row in listManager.rowList)
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
