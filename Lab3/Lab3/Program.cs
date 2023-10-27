using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Create animal list
            List<Animal> animals = new List<Animal>();

            //Takes in input from user if they want to add an animal to the list
            Console.WriteLine("***************************************************************************\n" +
                "Do you want to add an animal to the list? (1 = yes; 0 = no: ");

            byte continueAdd = byte.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");

            //Loops until user does not want to add anymore animals if they entered 1 on previous input
            while(continueAdd == 1)
            {
                //Asks dog or cat
                Console.WriteLine("Enter pet type ('Dog' or 'Cat')");
                string input = Console.ReadLine();

                //If 'dog' then creates and adds new dog to the list
                if ("Dog".Equals(input))
                {
                    animals.Add(CreateNewDog());
                }

                //If 'cat' then creates and adds new dog to the list 
                else if ("Cat".Equals(input))
                {
                    animals.Add(CreateNewCat());
                } 

                //If none of these then user entered wrong type
                else
                {
                    Console.WriteLine("You've entered a different type of animal, enter another animal with the correct type");
                }

                //Asks user if they want to add more
                Console.WriteLine("Do you want to add another animal to the list? (1 = yes; 0 = no: ");

                continueAdd = byte.Parse(Console.ReadLine());
            }

            //Prints all animal names from the list
            Console.WriteLine("***************************************************************************\n" +
                "Here is the names of all the animals added to the list: ");

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        //Method that creates new cat to minimize code in Main method
        public static Cat CreateNewCat()
        {
            Console.WriteLine("Input a cat name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Input a cat height: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Input a cat colour: ");
            string colour = Console.ReadLine();

            Console.WriteLine("Input a cat age: ");
            short age = short.Parse(Console.ReadLine());

            return new Cat(name, height, colour, age);
        }

        //Method that creates new dog to minimize code in Main method
        public static Dog CreateNewDog()
        {
            Console.WriteLine("Input a dog name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Input a dog height: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Input a dog colour: ");
            string colour = Console.ReadLine();

            Console.WriteLine("Input a dog age: ");
            short age = short.Parse(Console.ReadLine());

            return new Dog(name, height, colour, age);
        }
    }
}