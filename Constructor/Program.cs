using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Defaultconstructor
    {
            public string Name;
            public int Age;
        public Defaultconstructor(String namevalue, int Agevalue )
        {
            Name = namevalue;
            Age = Agevalue;
        }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Defaultconstructor D = new Defaultconstructor("nikesh",20);
                Console.WriteLine("Name is :"+ D.Name);
              Console.WriteLine("Age is "+ D.Age);
              Console.ReadKey();   
            }
        }

    }