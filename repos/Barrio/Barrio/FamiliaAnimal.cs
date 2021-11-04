using System;
using System.Collections.Generic;
using System.Text;

namespace Barrio
{
    class FamiliaAnimal
    {
        private string clase;
        private string dieta;

        public FamiliaAnimal() { }
        public FamiliaAnimal(string clase, string dieta)
        {
            this.clase = clase;
            this.dieta = dieta;
        }
        //gett y sett
        public string getClase() { return clase; }
        public string getDieta() { return dieta; }

        public void setClase(string clase) { this.clase = clase; }
        public void setDieta(string dieta) { this.dieta = dieta; }

        public override string ToString()
        {
            return "clase: "+clase+" dieta: "+dieta;
        }
    }
}
