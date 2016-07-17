using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    class Bruch
    {
        int zaehler = 1;
        int nenner = 1;

        public int Zaehler
        {
            get
            {
                return zaehler;
            }
            set
            {
                zaehler = value;
            }
        }

        public int Nenner
        {
            get
            {
                return nenner;
            }
            set
            {
                if (value != 0)
                {
                    nenner = value;
                }
            }
        }

        public void Frage()
        {
            Console.Write("Zaehler: ");
            zaehler = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nenner : ");
            Nenner = Convert.ToInt32(Console.ReadLine());
        }

        public void Zeige()
        {
            Console.WriteLine("   {0}\n  ‐‐‐‐‐\n   {1}\n", zaehler, nenner);
        }
    }
}
