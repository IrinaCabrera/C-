using System;
using System.Collections.Generic;
using System.Text;

namespace practicaProg3.EjFecha
{
    class Fecha
    {
       public DateTime[] feriados = { new DateTime (2021, 01, 16), new DateTime(2021, 03, 29),
                new DateTime(2021, 02, 28), new DateTime(2021, 04, 16), new DateTime(2021, 06, 14),
                new DateTime(2021, 06, 28) };

       
        //cantidad de dias entre dos fechas
       public void ObtenerDiasCalendario(DateTime inicio, DateTime final) {
            
            TimeSpan dias = final - inicio;
            Console.WriteLine(dias.TotalDays);
        }


        //obtiene los días laborables entre dos fechas
        public void ObtenerDiasLaborables(DateTime inicio, DateTime final) {
            int diasTotales = 0;
            for (DateTime i = inicio; i <= final; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    diasTotales -= 1;
                }
                else
                {
                    foreach (DateTime item in feriados)
                    {
                        if (i.CompareTo(item) == 0)
                        {
                            diasTotales -= 1;
                        }
                    }
                }
                 
                diasTotales += 1;

            }
            Console.WriteLine("Dias laborables totales: "+diasTotales);
        }
       
        
        //obtiene una fecha sumando una cantidad de días a una fecha inicial
        public void SumarDiasLaborables(DateTime inicio, int cantidad) {
            DateTime nuevaFecha = inicio.AddDays(cantidad);

            Console.WriteLine("fecha inicial: "+inicio+"Fecha despues de la sumatoria: "+nuevaFecha);
        }


    }
}
