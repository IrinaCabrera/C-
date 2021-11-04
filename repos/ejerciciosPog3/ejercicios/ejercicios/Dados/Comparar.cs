using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios.Dados
{
    //es uan persona que esta en la mesa y juzga el resultado del dado y la apuesta
    class Comparar
    {
        private string veredicto;

        public Comparar()
        {
        }
        public void Comparacion(int cara, int apuesta)
        {
            if (cara == apuesta)
            {
                veredicto = "Gana el apostador";
            }
            else
            {
                veredicto = "Pierde el apostador";
            }
        }

        public string getVeredicto()
        {
            return veredicto;
        }

        public override string ToString()
        {
            return "El veredicto es: "+getVeredicto();
        }

    }
}
