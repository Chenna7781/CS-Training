using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.OOP_Concepts.Abstraction
{
    public abstract class Animal
    {
        public abstract void MakeSound();
        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping..zzzzzzzzzzzzzz");
        }
    }

    public class Dog:Animal
    {
        public override void MakeSound()
        {
            
            Console.WriteLine("Dog Barks...Boww wwwwwwww");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            //When you dont wanna implement
            //throw new NotImplementedException();  //(no execution after this)
            Console.WriteLine("Cat Mewowwwww ssssssss");
        }
    }

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Animal a = new Dog();
    //        a.MakeSound();
    //        a.Sleep();

    //        Animal a1 = new Cat();
    //        a1.MakeSound();
    //        a1.Sleep();
    //    }


    }
