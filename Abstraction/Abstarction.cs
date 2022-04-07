using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Abstarction
    {
        static void Main(string [] args)
        {
            Program p = new Program();
            string loginresult = p.UserLogin("hello","gg");
            Console.WriteLine(loginresult);
            Console.ReadLine();
        }
    }

    public class Nikesh
    {
        private int login(string email, string password)
        {
            return 1;

        }
    }

}
