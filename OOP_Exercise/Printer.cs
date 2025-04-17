using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    internal class Printer : Machine
    {
        public Printer(string numSerie) : base(numSerie)
        {
            this.NumSerie = numSerie;
        }

        public override void encender()
        {
            Console.WriteLine("Impresora encendida");
        }

        public override void imprimirNumSerie()
        {
            Console.WriteLine($"Num de serie: {NumSerie}");
        }
    }
}
