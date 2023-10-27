using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface IAnimal
    {
        //Get and setters for shared fields in animals
        string Name { get; set; }
        string Colour { get; set; }
        float Height { get; set; }
        short Age {  get; set; }

        //Mandatory methods 
        public void Eat();

        public void Cry();
    }
}
