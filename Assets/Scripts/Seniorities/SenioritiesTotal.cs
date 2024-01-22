public class SenioritiesTotal
{
    public int GetSeniorityTotal(PositionType position, SeniorityType seniority, IEmployeesList employeesList)
    {
        int count = 0;

        foreach (var employee in employeesList.employeesList)
        {
            if (employee.position.Position == position && employee.seniority.Seniority == seniority)
            {
                count++;
            }
        }

        return count;
    }
}
