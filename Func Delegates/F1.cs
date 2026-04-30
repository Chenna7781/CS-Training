using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Func_Delegates
{
    internal class F1
    {
        void Strings()
        {
            Func<string> Greet = () => "Hello";
            Console.WriteLine(Greet());//Hello
        }
        void Square()
        {
            Func<int, int> Square = x => x * x;
            Console.WriteLine(Square(5)); //25
        }

        void Add()
        {
            Func<int,int,int> Sum = (x,y) => x + y;
            Console.WriteLine(Sum(10,20));//30
        }
        
    }
}
