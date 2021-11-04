using System;
using System.Collections.Generic;
using System.Text;

namespace Recu_PrimerParcial_CabreraIrina_Prog3
{
    class main
    {
        public static void Main(string[] args)
        {

            loteria jugada1 = new loteria();

            jugada1.noRepetir();

            usuario nuevoU = new usuario();

            jugada1.controlAciertos(nuevoU, jugada1);

            jugada1.ToString();
        }
    }
}
