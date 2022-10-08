namespace DemoOOP
{
    public abstract class BaseEmployee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAddress;

        public BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }

        public virtual void Show() => Console.WriteLine($"Id: {employeeID} Name: {employeeName} Address: {employeeAddress}");

        public abstract decimal CalculateSalary(int workingHours);

        public abstract string GetDepartment();
    }
}