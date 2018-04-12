using System;

namespace EmployeeProject
{
    abstract partial class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

        // Contain a BenefitPackage object
        protected BenefitPackage empBenefits = new BenefitPackage();

        public double GetBenefitCost()
        {
            // Expose certain benefit behaviors of object
            return empBenefits.ComputePayDeduction();
        }

        public BenefitPackage Benefits
        {
            get {return empBenefits;}
            set {empBenefits = value;}
        }
        public string Name
        {
            get { return empName; }
            set 
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!");
                else
                    empName = value;
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age 
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }

        public Employee() {}
        public Employee(string name, int id, float pay, string ssn)
        :this(name, 0, id, pay, ssn){}

        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
            empSSN = ssn;
        }

        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"Age: {empAge}");
            Console.WriteLine($"Pay: {currPay}");
        }
    }
}