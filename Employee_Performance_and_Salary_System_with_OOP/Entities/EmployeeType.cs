using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Performance_and_Salary_System_with_OOP.Entities
{
    class EmployeeType
    {
        private string _employeeType;


        public EmployeeType(string empType)
        {
            this._employeeType = empType;
        }


        public string getEmployeeType()
        {
            return _employeeType;
        }

    }
}
