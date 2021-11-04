using System;
using System.Collections.Generic;
using System.Text;

namespace Recu_PrimerParcial_CabreraIrina_Prog3
{
    class loteria
    {
        public Random rand = new Random();
        //que guarde los resultados en el arreglo
        public int[] resultado = new int[5];


        public void noRepetir()
        {
            
            int cont = 0;
            bool control = false;
            
            for (int i=0;i<5;i++)
            {
                int random = rand.Next(0, 51);
                if(cont == 0)
                {
                    resultado[cont] = random;
                    cont += 1;
                }
                else
                {
                    foreach (int item in resultado)
                    {
                        if (item == random)
                        {
                            control = true;
                        }
                    }
                    if (control == false)
                    {
                        resultado[cont] = random;
                        cont += 1;
                    }
                    else
                    {
                        control = false;
                    }
                    
                }
                
            }

            
        }

        public void controlAciertos(usuario usuario, loteria jugada)
        {
            int aciertos = usuario.procedimientoAciertos(jugada);
            DateTime hoy = DateTime.Now;
            DateTime plazoRetiroPremio = hoy.AddDays(30);
            switch (aciertos)
            {
                case 1:
                    Console.WriteLine("Usted tiene 10% de descuento en la siguiente compra");
                    Console.WriteLine("Tiene hasta el día: "+ plazoRetiroPremio+" para retirar su premio");
                    break;
                case 2:
                    Console.WriteLine("Usted tiene 20% de descuento en la siguiente compra");
                    Console.WriteLine("Tiene hasta el día: " + plazoRetiroPremio + " para retirar su premio");
                    break;
                case 3:
                    Console.WriteLine("Usted tiene 30% de descuento en la siguiente compra");
                    Console.WriteLine("Tiene hasta el día: " + plazoRetiroPremio + " para retirar su premio");
                    break;
                case 4:
                    Console.WriteLine("Usted tiene 50% de descuento en la siguiente compra");
                    Console.WriteLine("Tiene hasta el día: " + plazoRetiroPremio + " para retirar su premio");
                    break;
                case 5:
                    Console.WriteLine("Usted tiene 100% de descuento en la siguiente compra");
                    Console.WriteLine("Tiene hasta el día: " + plazoRetiroPremio + " para retirar su premio");
                    break;
                default:
                    Console.WriteLine("Usted no tiene descuento en la siguiente compra.");
                    //Console.WriteLine("Tiene hasta el día: " + plazoRetiroPremio + " para retirar su premio");
                    break;
            }
        }

        public override string ToString()
        {
            Console.WriteLine("Numeros de la loteria: ");
            foreach (int i in resultado)
            {
                Console.WriteLine(i);

            }
            return "";
        }

    }
}
