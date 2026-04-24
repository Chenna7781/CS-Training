using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Arrays
{
    internal class Matrix_addition
    {
        public static void sum(int[,] array1,int[,] array2)
        {
            int rows = array1.GetLength(0);
            int columns = array1.GetLength(1);
            int[,] c = new int[rows, columns];

            for(int i=0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    c[i, j] = array1[i, j] + array2[i, j];
                }
            }

            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }

            //int[,] a = { { 1, 2 }, { 3, 5 } };
            //int[,] b = { { 2, 3 }, { 4, 5 } };
            //Matrix_addition.sum(a, b);

        }
    }
}
