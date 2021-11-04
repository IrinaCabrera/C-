using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Parcial_Prog3_CabreraIrina.IntentoNuevo
{
    class Program
    {
        public static void Main(String[] args)
        {
            //string nombre;
            DateTime nacimiento;
            DateTime ahora = DateTime.Now;


           /* Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Nacimiento (año,mes,día): ");
            nacimiento = DateTime.Parse(Console.ReadLine());*/


           // Usuario nuevoUsuario = new Usuario(nombre,nacimiento);
            Usuario nuevoUsuario = new Usuario("irina", nacimiento =new DateTime(1998,1,16));
            Console.WriteLine(nuevoUsuario.ToString());

            Horoscopo prediccion = new Horoscopo();
            prediccion.foundSign(nuevoUsuario.getNacimiento());
            
            prediccion.prediccion(nacimiento,ahora);
        }
    }
}
