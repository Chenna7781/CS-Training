using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Collections.Lists
{
    internal class Numbers
    {

        
        
        public static void Lists()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            //to add elements using Add()
            numbers.Add(6);
            numbers.Add(7);

            //to know the length of list
            Console.WriteLine("Count : "+numbers.Count());


            //to print
            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }
        }
    }
}
