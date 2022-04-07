using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        interface MultipleA
        {
            int calculateSum();
        }
        class MultipleB
        {
            public int a, b;
            public void GetData(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }

        class MultipleC : MultipleB,MultipleA
        {
            public int calculateSum()
            {
                GetData(70, 80);
                int area = a * b;
                return area;
            }
        }
        
        static void Main(string[] args)
        {
            MultipleC M = new MultipleC();
            Console.WriteLine("Sum :" +M.calculateSum());
            Console.ReadKey();
        }
    }
}
