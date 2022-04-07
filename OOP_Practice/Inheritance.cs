using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Gfg // Parent class
    {
        public String name;
        public String subject;
        public void readers(String name, String subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself:"+ name);
            Console.WriteLine("My favourite Subject is :" + subject);
        }

    }

     class GreekforGreek: Gfg // child class
    {
        public GreekforGreek()
        {
            Console.WriteLine("GreekForGreek");
        }
    }

    internal class Inheritance // derived class
    {
        static void Main(String[] args)
        {
            GreekforGreek g = new GreekforGreek();
            g.readers("Nikesh", "C#");
        }

    }
}
