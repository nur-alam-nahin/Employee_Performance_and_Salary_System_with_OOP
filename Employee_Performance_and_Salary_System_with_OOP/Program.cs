using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Performance_and_Salary_System_with_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeSalaryMng.EmployeeSalaryMng employeeSalaryMng = new EmployeeSalaryMng.EmployeeSalaryMng();


            int num;

            do
            {
                Console.WriteLine("----- Employee Salary System -----");
                Console.WriteLine("1. Add Employee ");
                Console.WriteLine("2. view employee salary ");
                Console.WriteLine("3. Exite");
                Console.Write("Chose any number : ");
                num = Convert.ToInt32(Console.ReadLine());


                if (num > 0 && num < 3)
                {
                    switch (num)
                    {
                        case 1:
                            employeeSalaryMng.employee();
                            break;

                        case 2:
                            employeeSalaryMng.allEmpSalary();
                            break;
                    }

                }
            } while (num != 3);


            Console.ReadKey();
        }
    }
}
