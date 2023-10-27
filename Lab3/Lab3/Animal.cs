using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal abstract class Animal : IAnimal
    {
        //Fields
        string name, colour;
        short age;
        float height;

        //Get and setters from Interface
        public string Name { get => name; set => name = value; }
        public string Colour { get => colour; set => colour = value; }
        public short Age { get => age; set => age = value; }
        public float Height { get => height; set => height = value; }

        //Abstract methods from Interface inheritance
        public abstract void Eat();

        public abstract void Cry();
    }
}
