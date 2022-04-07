using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
     class Animal
    {
        public void Animalsound()
        {
            Console.WriteLine("The animal make a sound");
        }
    }
     class Pig: Animal
    {
        public void Animalsound()
        {
            Console.WriteLine(" The pig says : wee wee");
        }
    }

    class Dog : Animal
    {
        public void Animalsound()
        {
            Console.WriteLine("The Dogs says: bow wow");
        }
    }
    internal class Class1
    {
        static void Main(String[] args)
        {
            Animal myanimal = new Animal();
            Animal mypig = new Animal();
            Animal Dog = new Animal();
        }
    }
}
