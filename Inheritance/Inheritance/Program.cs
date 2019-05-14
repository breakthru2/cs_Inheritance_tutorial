using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("All animals eat");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog objDog = new Dog();
            objDog.Bark();
            objDog.Eat();

            Console.WriteLine("//////////////////////////");

            Cat objCat = new Cat();
            objCat.Meow();
            objCat.Eat();

            Console.ReadLine();
        }
    }
}
