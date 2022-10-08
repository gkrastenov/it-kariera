namespace DemoOOP
{
    public class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartment;

        public FullTimeEmployee(string employeePosition, string employeeDepartment, string employeeID, string employeeName, string employeeAddress)
          : base(employeeID, employeeName, employeeAddress)
        {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {employeePosition}");
            Console.WriteLine($"Department: {employeeDepartment}");
        }

        public override decimal CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80M;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}