using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Performance_and_Salary_System_with_OOP.EmployeeSalaryMng
{
    class EmployeeSalaryMng
    {
        public void employee()
        {
            Console.Write("Employee Id = ");
            int accountId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Employee Name = ");
            string name = Console.ReadLine();


            Console.Write("Employee type (Permanent/Contractual) =  ");
            string AcType = Console.ReadLine();


            Console.Write("Initial Balance = ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Entities.AccountType accountType = new Entities.AccountType(AcType);
            Entities.Customer cust = new Entities.Customer(accountId, balance, accountType);


            customers.Add(cust);
        }
    }
}
