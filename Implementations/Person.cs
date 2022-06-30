using Polymorphism___Abstraction___Inerface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism___Abstraction___Inerface
{
    public class Person : ISpeak,IEating,ICalculation
    {
        public void Eating(DateTime time)
        {
            Console.WriteLine("Person Eating-" + time);
        }

        public void Speak()
        {
            Console.WriteLine("Person speaking");
        }

        public void Sum(int a= 6, int b=3) 
        {
            Console.WriteLine(a + b);
        }

        public void Multiply(int a = 6, int b = 3)
        {
            Console.WriteLine(a * b);
        }

        public void Divide(int a = 6, int b = 3)
        {
            Console.WriteLine(a / b);
        }

        public void Minus(int a = 6, int b = 3)
        {
            Console.WriteLine(a - b);
        }


    }


   

   
}
