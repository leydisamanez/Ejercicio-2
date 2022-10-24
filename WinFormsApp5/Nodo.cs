using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Nodo
    {

        public double Pnumero;
        private Nodo siguiente;
        internal Nodo Siguiente
        {
            get => siguiente; set => siguiente = value;
        }
        public Nodo(double Ppre)
        {

            Pnumero = Ppre;

            siguiente = null;
        }
    }
}
