using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios.Dados
{
    class Dado
    {
        //propiedades (get set) mayuscula y luego minuscula
        //campos (no contiene get y set) mayusclas con _
        private int cara;

        public Dado()
        {

        }      
        public int rodar()
        {
            Random cara = new Random();
            this.cara = cara.Next(1, 7);
            return this.cara;
        }

        public int getCara()
        {
            return cara;
        }
        public void setCara()
        {
            cara=rodar();
            
        }
    }
}
