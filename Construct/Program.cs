using System;

namespace Construct
{
    internal class Program
    {
        class A
        {
            public string name;
            public int age;
            public A()//default Connstructor
            {
                name = "Nikesh";
                age = 21;

            }
            public A(String namevalue, int agevalue) // Parameter Constructor
            {
                this.name = namevalue;
                this.age = agevalue;
            }
        }
            static void Main(string[] args)
            {
            A a = new A();
            A a2 = new A("Aussie Boy",20);
            Console.WriteLine(a.name+a.age);
            Console.WriteLine(a2.name+a2.age);
            Console.ReadKey();

            }
        }
    }

