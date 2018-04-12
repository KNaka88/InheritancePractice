namespace EmployeeProject
{
    class SalesPerson : Employee
    {
        public SalesPerson() {}
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales): base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
        public int SalesNumber { get; set; }
    }

    class BenefitPackage
    {
        public double ComputePayDeduction()
        {
            return 125.0;
        }
    }
}