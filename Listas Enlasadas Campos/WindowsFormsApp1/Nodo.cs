using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Nodo
    {
        private string carga;
        private Nodo puntero;

        public Nodo(string Carga)
        {
            Carga = carga;
            Puntero = null;
        }

        public string Carga { get => carga; set => carga = value; }
        internal Nodo Puntero { get => puntero; set => puntero = value; }
    }
}
