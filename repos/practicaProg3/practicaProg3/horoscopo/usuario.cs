using System;
using System.Collections.Generic;
using System.Text;

namespace practicaProg3.horoscopo
{
    class usuario
    {
        private string nombre;
        private DateTime nacimiento = new DateTime();
        private string signo;
        private int peso;//este es el peso que le puse para que sea sumado en el rand.
        public usuario(string nombre, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.nacimiento = nacimiento;

        }

        public string getNombre()
        {
            return nombre;
        }
        public DateTime getNacimiento()
        {
            return nacimiento;
        }
        public string getSigno()
        {
            return signo;
        }
        public void setSigno(string signo)
        {
            this.signo = signo;
        }
        public int getPeso()
        {
            return peso;
        }
        public void setPeso(int peso)
        {
            this.peso = peso;
        }
        public override string ToString()
        {
            return "nombre: "+nombre+" signo: "+signo;
        }

    }
}
