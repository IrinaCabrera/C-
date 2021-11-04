using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Parcial_Prog3_CabreraIrina.Examen
{
    class Horoscopo
    {
        DateTime[] signosInicial = new DateTime[] { new DateTime (2021,12,21), new DateTime(2021, 1, 21), new DateTime(2021, 6, 21) };//capricorio, piscis y cancer.
        DateTime[] signosFinal = new DateTime[] { new DateTime(2021, 1, 20), new DateTime(2021, 2, 20), new DateTime(2021, 7, 20) };//capricorio, piscis y cancer.
        public Horoscopo()
        {

        }
        //detectar signo
        //Como este procedimiento no me funcinó de netrada, no pude seguir con el ejercicio.
        public void detectSigno(DateTime nacimiento)
        {  /*
            * mi idea era recorrer desde la primera fecha de signosInicial hasta llegar a la primera fecha del signosFinal
            * No está trminado y tampooc me funciona
            */
           
            foreach (DateTime item in signosInicial)
            {
               if(nacimiento.Month == item.Month)
                {
                    Console.WriteLine("mes igual");
                    
                    if (nacimiento.Day == item.Day)
                    {
                        Console.WriteLine("dia igual");
                    }
                    else
                    {
                        Console.WriteLine("dia distinto");
                        foreach (DateTime final in signosFinal)//Área del problema, se presenta un error lógico.
                        {
                            for (DateTime date = item; date <= final; date = date.AddDays(1.0))
                            {
                                if (nacimiento.CompareTo(date).Equals(0))
                                {
                                    Console.WriteLine("Fecha encontrada");

                                }
                            }
                        }
                        
                    }
                }
            }
            
        }
    }
}
