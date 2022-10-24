using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Lista
    {

        Nodo Pprimero;
        public Nodo Praiz;
        public Lista()
        {
            Pprimero = null;
        }
        public void insertar(double Pnumero)
        {
            if (Pprimero == null)
            {
                Pprimero = new Nodo(Pnumero);
                Praiz = Pprimero;
            }
            else
            {
                Nodo nuevo = new Nodo(Pnumero);
                Pprimero.Siguiente = nuevo;
                Pprimero = nuevo;
            }
        }
        public void desplegar(DataGridView data)
        {
            Nodo actual;
            actual = Praiz;
            data.Rows.Clear();
            while (actual != null)
            {
                data.Rows.Add(actual.Pnumero);
                actual = actual.Siguiente;
            }
        }
        public void buscar(double nom, DataGridView data)
        {
            Nodo actual = Praiz;
            while (actual.Pnumero != nom)
                actual = actual.Siguiente;
            data.Rows.Clear();
            data.Rows.Add(actual.Pnumero);
        }
        public void eliminar(double Pcod)
        {
            Nodo Pactual, Panterior;
            bool Pencontrado = false;
            Pactual = Praiz;
            Panterior = null;
            while (Pactual != null && !Pencontrado)
            {
                Pencontrado = (Pactual.Pnumero == Pcod);
                if (!Pencontrado)
                {
                    Panterior = Pactual;
                    Pactual = Pactual.Siguiente;
                }
            }
            if (Pactual != null)
            {
                if (Pactual == Praiz)
                {
                    Praiz = Pactual.Siguiente;
                }
                else
                {
                    Panterior.Siguiente = Pactual.Siguiente;
                }
                Pactual = null;






            }


        }

    }
}
