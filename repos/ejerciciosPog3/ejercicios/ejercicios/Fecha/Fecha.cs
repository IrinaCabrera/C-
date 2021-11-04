using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios.Fecha
{
    class Fecha
    {
        DateTime[] feriados = new DateTime[] { new DateTime(2021, 5, 1), new DateTime(2021, 5, 24), new DateTime(2021, 5, 25) };
        List<DateTime> diasLaborables = new List<DateTime>();
        bool poli = false;
        /*
        *Realice una clase utilitaria de manejo de tiempo y fechas que tenga al menos:
        *ObtenerDiasCalendario() obtiene los días entre dos fechas
        *ObtenerDiasLaborables() obtiene los días laborables entre dos fechas
        *SumarDiasLaborables() obtiene una fecha sumando una cantidad de días a una fecha inicial
        */

        public  string ObtenerDiasCalendario(DateTime fech1, DateTime fech2)
        {
            TimeSpan diferencia = fech2 - fech1;
            return "Días entre las dos fechas: "+diferencia.ToString("%d");
        }

        public void ObtenerDiasLaborables(DateTime fech1, DateTime fech2)
        {   
            for (DateTime date = fech1; date <= fech2; date = date.AddDays(1.0))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    
                }else
                {
                    foreach (DateTime fechuli in feriados)
                    {
                        if (date.CompareTo(fechuli).Equals(0))
                        {
                            poli = true;
                        }
                    }
                    if (poli == false)
                    {
                        diasLaborables.Add(date);
                    }
                    poli = false;
                }
            }
            Console.WriteLine("Dias laborables totales: "+diasLaborables.Count);
        }

        public void mostrarLista()
        {
            foreach (DateTime fechuli in diasLaborables)
            {
                Console.WriteLine(fechuli.ToString());

            }
        }

    }
}
