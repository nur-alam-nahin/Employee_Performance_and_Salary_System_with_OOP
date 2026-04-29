using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Performance_and_Salary_System_with_OOP.Entities
{
    class EmployeeInfo
    {
        private int _id;
        private string _name;
        private double _basicSalary;
        private double _bonus;

        private EmployeeType _EmployeeType;

        public EmployeeInfo(int id, string name, double basicSalary, EmployeeType EmployeeType)
        {
            _id = id;
            _name = name;
            _basicSalary = basicSalary;
            _EmployeeType = EmployeeType;

        }


        public int getId()
        {
            return _id;
        }


        public string getName()
        {
            return _name;
        }


        public double getSalary()
        {
            return _basicSalary;
        }


        public double getBonus()
        {
            return _bonus;
        }

        public EmployeeType getType()
        {
            return _EmployeeType;
        }

        

    }
}
