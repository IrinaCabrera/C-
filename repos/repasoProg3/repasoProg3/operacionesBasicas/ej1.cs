using System;
using System.Collections.Generic;
using System.Text;

namespace repasoProg3.operacionesBasicas
{
    class ej1
    {
        public static void Main(String[] args) {

            control nuevo = new control();
            string valorUno, valorDos;
            bool ingres;
            do
            {
                Console.WriteLine("ingrese el primer valor: ");

                valorUno = Console.ReadLine();

                ingres = nuevo.ingreso(valorUno);
                if (ingres != true)
                {
                    Console.WriteLine("Intente nuevamente");
                }
                else { break; }
            } while (ingres == false);

            Console.WriteLine(ingres +""+ valorUno+""+ valorUno.GetType()) ;
           // Console.WriteLine("ingrese el segundo valor: ");

           // valorDos = Console.ReadLine();



        }
    }
}
