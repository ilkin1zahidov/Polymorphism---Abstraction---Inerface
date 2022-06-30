
using Polymorphism___Abstraction___Inerface.Interfaces;
using Polymorphism___Abstraction___Inerface.Models;
using System;

namespace Polymorphism___Abstraction___Inerface
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.Sound();
            bird.Eat();

            Dog dog = new Dog();
            dog.Sound();
            dog.Eat();

            Test test = new Test();
            test.Id = 5;

            Person person = new Person();

            person.Speak();
            person.Eating(DateTime.Now);

            person.Sum();

            person.Multiply();

            person.Divide();
            person.Minus();



            
        }
    }
}
