public interface IApplyIncrementToRow
{
    float ApplyPercentageToRow(IEmployee employee);
}

public class ApplyIncrementToRow : IApplyIncrementToRow
{
    public float ApplyPercentageToRow(IEmployee employee)
    {
        var salaryToAdd = (employee.currentSalary * employee.salaryPercentage.IncrementPercentage) / 100;
        return employee.currentSalary += salaryToAdd;
    }
}
