using System;
using System.Collections.Generic;
using System.Text;

namespace Barrio
{
    class main
    {
        public static void Main(string[] args)
        {
            char confirm = 's';
            Barrio unicoBarrio = new Barrio();

            List<Casa> listCasa = new List<Casa>();
            Casa nuevaCasa = new Casa();

            List<Persona> listFamilia = new List<Persona>();
            Persona nuevaPersona = new Persona();

            List<Animal> listMascotas = new List<Animal>();
            Animal nuevaMascota = new Animal();

            Ambiente nuevoAmbiente = new Ambiente();
            List<Ambiente> listAmbiente = new List<Ambiente>();
            do {
                //Barrio unicoBarrio = new Barrio();


                Console.WriteLine("Bienvenido....Área de registro de casas...\nAgregue lo necesario:");

                //Console.WriteLine(unicoBarrio.getCasas().ToString());
               
                //Agrego personas
               /* do
                {
                    Console.WriteLine("La familia está compuesta por: ");
                    
                    listFamilia.Add(nuevaPersona.agregarPersona());
                    nuevaCasa.setFamilia(listFamilia);
                    
                    Console.WriteLine("Agregar mas personas? Sí: s / S, No: Cualquier tecla.");
                    confirm = char.Parse(Console.ReadLine());
                } while (confirm == 's' || confirm =='S') ; confirm = 's';

                //Agrego Mascotas
                do
                {
                    Console.WriteLine("La familia de cuatro patas está compuesta por: ");
                    
                    listMascotas.Add(nuevaMascota.agregarMascotas());
                    nuevaCasa.setMascota(listMascotas);
                    Console.WriteLine("Agregar mas mascotas? Sí: s / S, No: Cualquier tecla.");
                    confirm = char.Parse(Console.ReadLine());
                } while (confirm == 's' || confirm == 'S'); confirm = 's';*/
                
                //habitaciones y Ambiente
                do
                {
                    List<string> muebles = new List<string>();
                    Console.WriteLine("La casa contiene.....");
                    
                    //elegir tipo habitacion.
                    nuevoAmbiente.elegirTipoHabitacion(nuevoAmbiente);
                    
                    //dimensión de habitación.
                    Console.WriteLine("Cuál es la dimensión de la habitación?");
                    string dimension = Console.ReadLine();
                    nuevoAmbiente.setDimensionHabitacion(dimension);
                   
                    //cargar muebles.

                    nuevoAmbiente.setMuebles(nuevoAmbiente.cargarMuebles(muebles));
                    //

                    listAmbiente.Add(nuevoAmbiente);

                    nuevaCasa.setAmbiente(listAmbiente);

                   
                    Console.WriteLine("Agregar mas habitaciones a la casa? Sí: s / S, No: Cualquier tecla.");
                    confirm = char.Parse(Console.ReadLine());
                    Console.WriteLine(nuevaCasa.ToString());
                    
                } while (confirm == 's' || confirm == 'S'); confirm = 's';



                //TENGO QUE AGREGAR MAS COSAS PARA CARGAR LA LISTA DE CASAS AL FINAL.....SE LLAMA ListCasas......




                //agrego la casa a mi barrio//*****VERIFICAR ESTO DE CARGAR CASAS A UN BARRIO*******
                if (unicoBarrio.casasVacia() == 0)
                {
                    unicoBarrio.setCasas(listCasa);
                }
                else
                {
                    
                    
                }

                
                Console.WriteLine("Agregar mas cosas a la casa? Sí: s / S, No: Cualquier tecla.");
                confirm = char.Parse(Console.ReadLine());
                nuevaCasa.ToString();
            } while (confirm == 's' || confirm == 'S'); confirm = 's';
            

            

        }
    }
}
