using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios.Dados
{
    class Usuario
    {
        private int apuesta;


        public Usuario()
        {
        }

        public int generarApuesta()
        {
            Console.WriteLine("Ingrese un numero del 1 al 6 para apostar: ");
            int nuevaApuesta = int.Parse(Console.ReadLine());
            this.apuesta = nuevaApuesta;
            return this.apuesta;
        }
        public int getApuesta()
        {
            return apuesta;
        }
        public void setApuesta(int apuesta)
        {
            this.apuesta = apuesta;
        }
    }
}
