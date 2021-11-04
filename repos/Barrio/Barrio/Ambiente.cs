using System;
using System.Collections.Generic;

namespace Barrio
{
    class Ambiente
    {
        private List<string> muebles = new List<string>();
        private string tipoHabitacion;
        private string dimensionHabitacion;
        

        public Ambiente() { }
        public Ambiente(List<string> muebles, string tipoHab, string dimHab)
        {
            this.muebles = muebles;
            this.tipoHabitacion = tipoHab;
            this.dimensionHabitacion = dimHab;
            
        }

        //get sett
        public List<string> getMuebles() { return muebles; }
        public string getTipoHabitacion() { return tipoHabitacion; }
        public string getDimensionHabitacion() { return dimensionHabitacion; }
        
        public void setMuebles(List<string> muebles){ this.muebles = muebles; }
        public void setTipoHabitacion(string tipoHabitacion) { this.tipoHabitacion = tipoHabitacion; }
        public void setDimensionHabitacion(string dimensionHabitacion) { this.dimensionHabitacion = dimensionHabitacion;}
        


        public void elegirTipoHabitacion(Ambiente ambiente)
        {

            Console.WriteLine("tipo de habitación: \n1) Baño. \n2) Dormitorio. \n3) Cocina. \n4) Garage. \n5) Patio. \n6) Terraza");
            int select = int.Parse(Console.ReadLine());
            do
            {
                switch (select)
                {
                    case 1:
                        ambiente.tipoHabitacion = "Baño";
                        break;
                    case 2:
                        ambiente.tipoHabitacion = "Dormitorio";
                        break;
                    case 3:
                        ambiente.tipoHabitacion = "Cocina";
                        break;
                    case 4:
                        ambiente.tipoHabitacion = "Garage";
                        break;
                    case 5:
                        ambiente.tipoHabitacion = "Patio";
                        break;
                    case 6:
                        ambiente.tipoHabitacion = "Terraza";
                        break;
                    default:
                        Console.WriteLine("Tecla equivocada.");
                        break;

                }

            } while (select > 6);

        }
        //cargar muebles
        public List <string> cargarMuebles( List <string> muebles)
        {
            int cant;
            char confirm ='s';
            
            do {
                Console.WriteLine("¿Cuántos muebles desea agregar?");
                cant = int.Parse(Console.ReadLine());
                Console.WriteLine("Cargue los muebles de la habitacion: ");
                for (int i = 0; i < cant; i++)
                {
                    Console.WriteLine("nombre del mueble: ");
                    string nombreMueble = Console.ReadLine();
                    muebles.Add(nombreMueble);
                }
                Console.WriteLine("Agregar mas muebles? Sí: s / S, No: Cualquier tecla.");
                confirm = char.Parse(Console.ReadLine());
            } while (confirm == 's' || confirm == 'S'); confirm = 's';
           
            return muebles;
        }
       
        public string mostrarMuebles()
        {
            Console.WriteLine("Su casa contiene: ");
            foreach (String x in muebles)Console.WriteLine(x);
            return "";
        }

        public override string ToString()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("tipo: " + tipoHabitacion + ", dimension: " + dimensionHabitacion);
            mostrarMuebles();
            Console.WriteLine("------------------------");
            return "";

        }


    }
}
