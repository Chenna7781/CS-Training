using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Arrays
{
    internal class Print2DArray
    {
        public static void print()
        {
            //rows
            Console.WriteLine("Enter the no of rows :");
            int rows= Convert.ToInt32(Console.ReadLine());

            //columns
            Console.WriteLine("Enter the no of columns :");
            int columns;
            int.TryParse(Console.ReadLine(), out columns);

            //Array creation
            int[,] arr = new int[rows,columns];


            //take elements from user
            Console.WriteLine("Enter the Elements");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }

            }


            //to print elements
            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
