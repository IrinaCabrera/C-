using System;
using System.Collections.Generic;
using System.Text;

namespace practicaProg3.horoscopo
{
    class main
    {
        public static void Main(string[] args)
        {
            usuario nuevoUsuario = new usuario("Irina",new DateTime(2020,04,16));
            horoscopo nuevaPrediccion = new horoscopo();

            nuevaPrediccion.averiguarSigno(nuevoUsuario.getNacimiento(),nuevoUsuario);

            Console.WriteLine(nuevoUsuario.ToString());

            nuevaPrediccion.prediccion(nuevoUsuario);
        }
    }
}
