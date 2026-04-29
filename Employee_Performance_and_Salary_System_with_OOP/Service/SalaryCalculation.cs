using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Performance_and_Salary_System_with_OOP.Entities;

namespace Employee_Performance_and_Salary_System_with_OOP.Service
{
    abstract class SalaryCalculation
    {
        protected EmployeeInfo _employeeInfo;


        public SalaryCalculation(EmployeeInfo employeeInfo)
        {
            _employeeInfo = employeeInfo;
        }


        public abstract double calculation();

    }
}
