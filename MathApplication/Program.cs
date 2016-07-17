using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bruch b1 = new Bruch();
            Console.WriteLine("1. Bruch");
            b1.Frage();
            b1.Zeige();
            Console.ReadKey();
        }
    }
}
