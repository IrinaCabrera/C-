using System;
using System.Collections.Generic;
using System.Text;

namespace primerExamen
{
    class ej_est_decision
    {
        /*Objetivo: Comprender la aplicación de las estructuras de decisión.
        Ejercicio:

            Cree una aplicación de consola.
            Solicite el ingreso de un texto y controle que no esté vacío.
            Despliegue un menú que muestre 3 opciones (Texto en mayúscula, Texto en minúscula y Texto Original).
            Capture la entrada con Console.Readkey y realice la opción solicitada.

         */
        /*      static void Main(string[] args)
              {
                  char ing;
                  string ingreso;
                  ConsoleKeyInfo selec;

                  do
                  {
                      Console.WriteLine("ingrese un texto");
                      ingreso = Console.ReadLine();
                      if (ingreso.Length > 0)
                      {
                          Console.WriteLine("1) Texto en mayúscula, 2) Texto en minúscula y 3) Texto Original");
                          selec = Console.ReadKey();
                          Console.WriteLine("");
                          switch (selec.Key)
                          {
                              case ConsoleKey.D1:
                                  Console.WriteLine(ingreso.ToUpper());
                                  break;
                              case ConsoleKey.D2:
                                  Console.WriteLine(ingreso.ToLower());
                                  break;
                              case ConsoleKey.D3:
                                  Console.WriteLine(ingreso);
                                  break;
                              default:
                                  Console.WriteLine("Ingreso no válido");
                                  break;
                          }

                      }
                      else
                      {
                          Console.WriteLine("su ingreso no es válido. Está vacío.");
                      }
                      Console.WriteLine("Volver a comenzar? S/N");
                       ing=Char.Parse(Console.ReadLine());
                  } while (ing == 'S' || ing == 's');

              }
          }*/
    }
}
