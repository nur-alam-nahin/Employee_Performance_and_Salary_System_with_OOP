using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Performance_and_Salary_System_with_OOP.Entities;


namespace Employee_Performance_and_Salary_System_with_OOP.Service
{
    class ContractualEmpSalary : SalaryCalculation
    {

        public ContractualEmpSalary(EmployeeInfo employeeInfo) : base(employeeInfo)
        {

        }
        public override double calculation()
        {
            return _employeeInfo.getSalary();
        }
    }
}
