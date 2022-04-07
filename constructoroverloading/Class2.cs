using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoroverloading
{    
    internal class Class2
    {
        abstract class A
        {
            public void messageA()
            {
                Console.WriteLine("Running From abstract A");
            }
            class B : A
            {
                public void messageB()
                {
                    Console.WriteLine("Running another class");
                }
            }
            static void Main(string[] args)
            {
                B b = new B();
                b.messageA();
                b.messageB();
                Console.ReadKey();
            }
        }
    }
    
}
