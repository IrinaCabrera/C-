using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Parcial_Prog3_CabreraIrina.IntentoNuevo
{
    class Usuario
    {
        private string nombre;
        private DateTime nacimiento = new DateTime();

        public Usuario(string nombre, DateTime nacimiento)
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
       
        public override string ToString()
        {
            return "Nombre: "+getNombre()+"; Nacimiento: "+getNacimiento().ToString("MM/dd/yyyy");
        }
    }
}
