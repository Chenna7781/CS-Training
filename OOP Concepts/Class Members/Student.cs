using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.OOP_Concepts.Class_Members
{
    internal class Student
    {
        //instance variables
        int stdID;
        string stdName;
        double marks;

        //static variables
        const string COLLEGE = "Mallareddy";

        public Student(int stdID, string stdName, double marks)
        {
            this.stdID = stdID;
            this.stdName = stdName;
            this.marks = marks;
        }

        public void getDetails()
        {
            Console.WriteLine(stdID+" "+stdName+" "+marks+" "+COLLEGE);
        }

        public static void main()
        {
            Student s = new Student(1,"Rudra",12.22);
            s.getDetails();

        }
    }
}
