using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoroverloading
{
    internal class Constructor
    {
        class test1
        {
            public string name, location;

            public test1 ()
            {
                name = "Nikesh";
                location = "KTM";
            }
            public test1(string nameValue, string loacationValue)
            {
                name = nameValue;
                location = loacationValue;
            }
        }

        class test
        {
            static void Main(string[] args)
            {
                test1 a = new test1();  
                test1 b = new test1("NIKESH", "NEapl");
                Console.WriteLine(a.name+a.location);
                Console.WriteLine(b.name+b.location);
                Console.ReadKey();  
            }
        }


    }
}
