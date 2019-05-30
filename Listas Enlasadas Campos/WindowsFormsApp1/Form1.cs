using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

            //Lista_Simple ListaA = new Lista_Simple();
            //ListaA.Add("B");
            //ListaA.Add("C");

            //Lista_Simple ListaB = new Lista_Simple();
            //ListaB.Add("D");
            //ListaB.Add("E");

            //Lista_Simple ListaC = new Lista_Simple();
            //ListaC.Add("F");
            //ListaC.Add("G");

            //Lista_Simple ListaD = new Lista_Simple();
            //ListaD.Add("H");
            //ListaD.Add("I");

            //Lista_Simple ListaE = new Lista_Simple();
            //ListaE.Add("J");
            //ListaE.Add("K");

            //Lista_Simple ListaF = new Lista_Simple();
            //ListaF.Add("L");
            //ListaF.Add("M");

            //Lista_Simple ListaG = new Lista_Simple();
            //ListaG.Add("N");
            //ListaG.Add("O");

            //Lista_Simple ListaH = new Lista_Simple();

            //Lista_Simple ListaI = new Lista_Simple();
            //ListaI.Add("P");
            //ListaI.Add("Q");

            //Lista_Simple ListaJ = new Lista_Simple();
            //ListaJ.Add("R");
            //ListaJ.Add("S");

            //Lista_Simple ListaK = new Lista_Simple();

            //Lista_Simple ListaL = new Lista_Simple();
            //ListaL.Add("T");
            //ListaL.Add("U");

            //Lista_Simple ListaM = new Lista_Simple();

            //Lista_Simple ListaN = new Lista_Simple();
            //ListaN.Add("V");

            //Lista_Simple ListaO = new Lista_Simple();
            //ListaO.Add("W");

            //Lista_Simple ListaP = new Lista_Simple();

            //Lista_Simple ListaQ = new Lista_Simple();

            //Lista_Simple ListaR = new Lista_Simple();

            //Lista_Simple ListaS = new Lista_Simple();
            //ListaS.Add("X");
            //ListaS.Add("Y");

            //Lista_Simple ListaT = new Lista_Simple();

            //Lista_Simple ListaU = new Lista_Simple();

            //Lista_Simple ListaV = new Lista_Simple();

            //Lista_Simple ListaW = new Lista_Simple();

            //Lista_Simple ListaX = new Lista_Simple();
            //ListaX.Add("Z");

            //Lista_Simple ListaY = new Lista_Simple();
            //ListaX.Add("Z");
            Nodos _nodos = _llenarDatos();
           
            foreach (var item in textbox1.Text)//SE RECORRE LO ESCRITO EN EL TEXTBOX Y EL VALOR SE GUARDA EN LA VARIABLE ITEM
            {
                if (item == '0')//SE CONDICIONA SI EL VALOR DE ITEM = 0
                    _nodos = _nodos.Nodo0;
                else
                    _nodos = _nodos.Nodo1;
            }
                TXT1.Text = _nodos.Valor;
        }
        private Nodos _llenarDatos() {
            Nodos _A = new Nodos() { Valor = "A" };
            Nodos _B = new Nodos() { Valor = "B" };
            Nodos _C = new Nodos() { Valor = "C" };
            Nodos _D = new Nodos() { Valor = "D" };
            Nodos _E = new Nodos() { Valor = "E" };
            Nodos _F = new Nodos() { Valor = "F" };
            Nodos _G = new Nodos() { Valor = "G" };
            Nodos _H = new Nodos() { Valor = "H" };
            Nodos _I = new Nodos() { Valor = "I" };
            Nodos _J = new Nodos() { Valor = "J" };
            Nodos _K = new Nodos() { Valor = "K" };
            Nodos _L = new Nodos() { Valor = "L" };
            Nodos _M = new Nodos() { Valor = "M" };
            Nodos _N = new Nodos() { Valor = "N" };
            Nodos _O = new Nodos() { Valor = "O" };
            Nodos _P = new Nodos() { Valor = "P" };
            Nodos _Q = new Nodos() { Valor = "Q" };
            Nodos _R = new Nodos() { Valor = "R" };
            Nodos _S = new Nodos() { Valor = "S" };
            Nodos _T = new Nodos() { Valor = "T" };
            Nodos _U = new Nodos() { Valor = "U" };
            Nodos _V = new Nodos() { Valor = "V" };
            Nodos _W = new Nodos() { Valor = "W" };
            Nodos _X = new Nodos() { Valor = "X" };
            Nodos _Y = new Nodos() { Valor = "Y" };
            Nodos _Z = new Nodos() { Valor = "Z" };

            _A.Nodo0 = _B;
            _A.Nodo1 = _C;

            _B.Nodo0 = _D;
            _B.Nodo1 = _E;

            _C.Nodo0 = _F;
            _C.Nodo1 = _G;

            _E.Nodo0 = _L;
            _E.Nodo1 = _K;

            _F.Nodo0 = _L;
            _F.Nodo1 = _M;

            _G.Nodo0 = _N;
            _G.Nodo1 = _O;

            _I.Nodo0 = _P;
            _I.Nodo1 = _Q;

            _J.Nodo0 = _R;
            _J.Nodo1 = _S;

            _L.Nodo0 = _T;
            _L.Nodo1 = _U;

            _N.Nodo0 = _V;

            _O.Nodo1 = _W;

            _S.Nodo0 = _X;
            _S.Nodo1 = _V;

            _X.Nodo0 = _Z;

            _Y.Nodo0 = _Z;

            return _A;
        }
    }
}
