using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios.Fecha
{
    class main
    {
        /*
        *Realice una clase utilitaria de manejo de tiempo y fechas que tenga al menos:
        *ObtenerDiasCalendario() obtiene los días entre dos fechas
        *ObtenerDiasLaborales() obtiene los días laborables entre dos fechas
        *SumarDiasLaborables() obtiene una fecha sumando una cantidad de días a una fecha inicial
        *Tenga en cuenta fines de semanas y feriados
        *Puede guardar los feriados en un arreglo

         */
        static void Main(string[] args)
        {
            Fecha newDate = new Fecha();
            Console.WriteLine(newDate.ObtenerDiasCalendario(new DateTime(2008, 5, 1), new DateTime(2008, 8, 1)));
            /*---------------------------------------------*/
            newDate.ObtenerDiasLaborables(new DateTime(2021, 5, 1), new DateTime(2021, 5, 31));
            newDate.mostrarLista();

        }
    }
}
