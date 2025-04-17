using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal class Computer : IComputer
    {
        public void encender()
        {
            Console.WriteLine("Computadora encendida");
        }

        public int restar(int a, int b)
        {
            return a - b;
        }

        public int sumar(int a, int b)
        {
            return a + b;
        }
    }
}
