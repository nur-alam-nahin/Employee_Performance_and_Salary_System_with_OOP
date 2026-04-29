using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Performance_and_Salary_System_with_OOP.Entities;


namespace Employee_Performance_and_Salary_System_with_OOP.Service
{
    class PermanentEmpSalary : SalaryCalculation
    {

        public PermanentEmpSalary(EmployeeInfo employeeInfo) : base(employeeInfo)
        {

        }
        public override double calculation()
        {
            double final = _employeeInfo.getSalary() + _employeeInfo.getBonus();

            return final;
        }
    }
}
