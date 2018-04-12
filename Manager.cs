namespace EmployeeProject
{
    class Manager: Employee
    {
        public int StockOptions { get; set; }
        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts): base(fullName, age, empID, currPay, ssn)
        {
            StockOptions = numbOfOpts;
        }

    }

}