using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    public abstract class Machine
    {
        protected string _numSerie;
        public string NumSerie
        {
            get { return _numSerie; }
            set { _numSerie = value; }
        }

        public Machine(string numSerie)
        {
            this._numSerie = numSerie;
        }

        public abstract void encender();

        public abstract void imprimirNumSerie();
    }
}
