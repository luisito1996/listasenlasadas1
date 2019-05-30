using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Lista_Simple
    {
        private Nodo inicio;

        internal Nodo Inicio { get => inicio; set => inicio = value; }

        public Lista_Simple ()
        {
            Inicio = null;
        }

        #region Metodo Add-Agregar un dato a la lista

        public void Add(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            {
                if (Inicio==null)
                {
                    Inicio = nuevo;
                }
                else
                {
                    Nodo aux = IterarNodo(Inicio);
                    aux.Puntero = nuevo;
                }
            }
        }

        private Nodo IterarNodo(Nodo Inicio)
        {
            if (Inicio.Puntero==null)
            {
                return Inicio;
            }
            else
            {
                return IterarNodo(Inicio.Puntero);
            }
        }
        #endregion
    }
}
