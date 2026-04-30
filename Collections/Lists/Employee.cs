using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Collections.Lists
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            
        }
        public Employee(string Name,int Id, double Salary)
        {
            this.Name = Name;
            this.Id = Id;
            this.Salary = Salary;
        }
        public static void EmpDetails()
        {
            //creating a list to store the data
            List<Employee> emp = new List<Employee>();

            //adding emmployees
            Employee e1 = new Employee();
            e1.Name = "sweety";
            e1.Salary = 123123.23;
            e1.Id = 1;

            emp.Add(e1);
            emp.Add(new Employee("raju", 2, 1234213.22));

            foreach (var item in emp)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Salary);
            }
        }
    }
}
