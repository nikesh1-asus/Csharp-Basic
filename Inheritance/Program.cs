using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        class A
        {
            public void Test()
            {
                Console.WriteLine("this is A");
            }
            
        }

        class B : A
        {
            public void Test1()
            {
                Console.WriteLine("this is B");
               
            }
        }

         class C: A
        {
            public void Test2()
            {
                Console.WriteLine(" this is C");
            }
        }
        static void Main(string[] args)
        {
            B b = new B();
            C c = new C();
             
            b.Test1();
           

            c.Test();
           c.Test2();

            Console.ReadKey();

        }
    }
}
