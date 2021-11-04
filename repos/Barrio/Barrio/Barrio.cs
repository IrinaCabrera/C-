using System;
using System.Collections.Generic;
using System.Text;

namespace Barrio
{
    class Barrio
    {
        private List<Casa> casas = new List<Casa>();
        private string nombreCasa;//quizas se refiera a la familia o directamente al numero de la casa pero eso ya esta en la dirección..
        public Barrio() { }
        public Barrio(List<Casa> casas)
        {
            this.casas = casas;
        }

        public List<Casa> getCasas() { return casas; }
        public string getNombreCasa() { return nombreCasa; }
        public void setNombreCasa(string nuevoNombre) { nombreCasa = nuevoNombre; }
        public void setCasas(List <Casa> casas) { this.casas = casas; }
        public int casasVacia()
        {
            if (casas.Count == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public string mostrar()
        {
            foreach (Casa r in casas)Console.WriteLine(r);
            return "";
        }

        public override string ToString()
        { 
            return mostrar();
        }
    }
}
