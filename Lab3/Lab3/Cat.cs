using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Cat : Animal
    {
        //Constructor
        public Cat(string name, float height, string colour, short age)
        {
            Name = name;
            Height = height;
            Colour = colour;
            Age = age;
        }

        //Overriden Eat fucntion
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

        //Overriden Cry function
        public override void Cry()
        {
            Console.WriteLine("Meow");
        }
    }
}
