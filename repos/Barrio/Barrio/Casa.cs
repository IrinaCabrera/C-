using System;
using System.Collections.Generic;
using System.Text;

namespace Barrio
{
    class Casa
    {
        private List<Persona> familia = new List<Persona>();
        private List<Animal> mascota = new List<Animal>();
        private List<Ambiente> ambiente = new List<Ambiente>();
        private Dictionary<string, string> servicios = new Dictionary<string, string>();

        public Casa() { }
        public Casa(List<Persona> familia, List<Animal> mascota, List<Ambiente> ambiente, Dictionary<string, string> servicios)
        {
            this.familia = familia;
            this.mascota = mascota;
            this.ambiente = ambiente;
            this.servicios = servicios;
        }
        public Persona agregarPersona()
        {
            Console.WriteLine("Agregue una persona:\n Nombre?: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Sexo?: ");
            char sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Edad?: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("fecha de nacimiento?: ");
            string nac = (Console.ReadLine());
            Console.WriteLine("(Ejemplo: padre / hijo ) Rol?: ");
            string rol = (Console.ReadLine());
            Persona nuevaPersona = new Persona(nombre, sexo, edad, nac, rol);

            return nuevaPersona;
        }

        //get
        public List<Persona> getFamilia(){return familia;}
        public List<Animal> getMascota() { return mascota; }
        public List<Ambiente> getAmbiente() { return ambiente; }
        public Dictionary<string, string> getServicio() { return servicios; }
        //set
        public void setFamilia(List<Persona> familia) { this.familia = familia; }
        public void setMascota(List<Animal> mascota) { this.mascota = mascota; }
        public void setAmbiente(List<Ambiente> ambiente) { this.ambiente = ambiente; }
        public void setServicios(Dictionary<string, string> servicios) { this.servicios = servicios; }

        //metodos
        //lleno el diccionario que contiene todos los servicios de la casa en especial
        public void cargaDiccServicio()
        {

            string valor;
            Console.WriteLine("Agregue sus servicios:");
            Console.WriteLine("Empresa de internet y cable:");
            valor = Console.ReadLine();
            servicios.Add("Empresa de internet y cable", valor);
            Console.WriteLine("Velocidad de internet (ej: 10 MBPS):");
            valor = Console.ReadLine();
            servicios.Add("Velocidad de internet", valor);
            Console.WriteLine("Instalacion eléctrica (trifásica o monofásica):");
            valor = Console.ReadLine();
            servicios.Add("Instalacion eléctrica", valor);
            
        }

        public string mostrarServicios()
        {
            foreach (KeyValuePair<string, string> par in servicios)
            {
                Console.WriteLine("su " + par.Key + " es " + par.Value);
            }
            return "";
        }
        public string mostrarFamilia()
        {
            foreach (Persona x in familia)Console.WriteLine(x);
            return "";
        }
        
        public string mostrarMascota()
        {
            foreach (Animal x in mascota)Console.WriteLine(x);
            return "";
        }
        public string mostrarAmbiente()
        {
            foreach (Ambiente x in ambiente)Console.WriteLine(x);
            return "";
        }

        public override string ToString()
        {
           // mostrarFamilia();
            //mostrarMascota();
            mostrarAmbiente();
            //mostrarServicios();
            return "";
        }
    }
}
