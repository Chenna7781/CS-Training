using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Class_Members
{
    internal class EmployeeMembers
    {
        //static variable
        public static string companyName = "Acuvate";

        //instance variables
        int empid;
        string name;

        //non - parameterized constructor
        public EmployeeMembers() { }

        //parmeterized constructor
        public EmployeeMembers(int empid,string name) {
            this.empid = empid;
            this.name = name;
        }

        //instance method
        public void getDetails()
        {
            Console.WriteLine("Name : " + name + " " + " Employeeid : " + empid + " " + " CompanyName : " + companyName);
        }

        //static method
        public static void Company()
        {
            EmployeeMembers e = new EmployeeMembers();
            e.empid = 1;
            e.name = "Raju";
            e.getDetails();

            EmployeeMembers e1 = new EmployeeMembers();
            e1.empid = 2;
            e1.name = "Sam";
            e1.getDetails();


            EmployeeMembers e2 = new EmployeeMembers(4, "Bittu");
            e2.getDetails();

            Console.WriteLine(new EmployeeMembers().name = "Sweety");
            Console.WriteLine(new EmployeeMembers().empid = 3);
        }

    }
}
