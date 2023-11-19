namespace OpenClose
{
    public class EmployeePartTime :Employee
    {
       

        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;
           // Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
           return salary;
        }
    }
}