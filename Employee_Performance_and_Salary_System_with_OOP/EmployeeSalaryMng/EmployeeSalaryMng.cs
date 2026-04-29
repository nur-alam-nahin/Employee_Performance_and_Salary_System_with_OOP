using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Performance_and_Salary_System_with_OOP.EmployeeSalaryMng
{
    class EmployeeSalaryMng
    {

        List<Entities.EmployeeInfo> employeeInfos = new List<Entities.EmployeeInfo>();


        // Employee info
        public void employee()
        {
            Console.Write("Employee Id = ");
            int empId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Employee Name = ");
            string empName = Console.ReadLine();


            Console.Write("Employee type (Permanent/Contractual) =  ");
            string empType = Console.ReadLine();

            Console.Write("Basic Salary = ");
            double empSalary = Convert.ToDouble(Console.ReadLine());


            Entities.EmployeeType employeeType = new Entities.EmployeeType(empType);
            Entities.EmployeeInfo employeeInfo = new Entities.EmployeeInfo(empId, empName, empSalary , employeeType);

            if(empType == "Permanent")
            {
                Console.Write("Employee Bonus = ");
                double empBonus = Convert.ToDouble(Console.ReadLine());
                employeeInfo.setBonus(empBonus);
            }



            employeeInfos.Add(employeeInfo);

        }


        // all employee balance check
        
        public void allEmpSalary()
        {
            foreach(var e in employeeInfos)
            {

                Service.SalaryCalculation salaryCalculation;
                if(e.getType().getEmployeeType() == "Permanent")
                {
                    salaryCalculation = new Service.PermanentEmpSalary(e);
                }
                else
                {
                    salaryCalculation = new Service.ContractualEmpSalary(e);
                }


                Console.WriteLine();
                Console.WriteLine("Employee Id : " + e.getId());
                Console.WriteLine("Employee Name : " + e.getName());
                Console.WriteLine("Employee Type : " + e.getType().getEmployeeType());
                Console.WriteLine("Employee Salary : " + salaryCalculation.calculation());
            }
        }

    }
}
