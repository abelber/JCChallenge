using System.Collections.Generic;

public class PositionsTotal
{
    public int GetPositionTotal(PositionType positionType, IEmployeesList employeesList)
    {
        int count = 0;

        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == positionType)
            {
                count++;
            }
        }

        return count;
    }
}
