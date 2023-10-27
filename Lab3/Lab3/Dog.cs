using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Dog : Animal
    {
        //Constructor
        public Dog(string name, float height, string colour, short age)
        {
            Name = name;
            Height = height;
            Colour = colour;
            Age = age;
        }

        //Overriden Eat fucntion
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        //Overriden Cry function
        public override void Cry()
        {
            Console.WriteLine("Woof!");
        }
    }
}
