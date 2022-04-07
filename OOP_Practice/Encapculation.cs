using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{

    public class Department
    {
        private string departname;
        public string Departname
        {
            get
            {
                return departname;
            }
            set
            {
                departname = value;
            }
        }
    }
    public class Departmentmain
    {
        public static int Main(string[] args)
        {
            Department d = new Department();
           d.Departname = "Communication";
            Console.WriteLine("The Department is :{0}", d.Departname);
            return 0;
        }
    }
}
