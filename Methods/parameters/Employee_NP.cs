using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Methods.parameters
{
    internal class Employee_NP
    {
        public static void empDetails(int empid,string name, int salary)
        {
            Console.WriteLine("EmployeeID : " + empid + " Employee Name : " + name + " Salary: " + salary);
        }

       // Employee_NP.empDetails(salary: 123000, empid: 123, name: "Rudra");
    }
}
