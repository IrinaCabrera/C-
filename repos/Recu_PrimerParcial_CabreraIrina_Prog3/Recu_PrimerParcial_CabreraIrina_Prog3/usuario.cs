using System;
using System.Collections.Generic;
using System.Text;

namespace Recu_PrimerParcial_CabreraIrina_Prog3
{
    class usuario
    {

        public int procedimientoAciertos(loteria juego)
        {
            Console.WriteLine("intente acertar los 5 numeros del 0 al 50 :)");
            int aciertos = 0;
            for (int i=0; i<5;i++)
            {
                Console.WriteLine((i+1)+"° intento: ");
                int ingreso = int.Parse(Console.ReadLine());

                foreach (int x in juego.resultado)
                {
                    if (ingreso == x) {
                        aciertos += 1;
                    }
                }
            }
            return aciertos;
            
        }

    }
}
