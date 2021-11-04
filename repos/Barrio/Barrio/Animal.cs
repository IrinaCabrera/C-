using System;
using System.Collections.Generic;
using System.Text;

namespace Barrio
{
    class Animal : FamiliaAnimal
    {
        private string nombre;
        private string tipo;
        private string categoria;
        private int edad;
        private string origen;

        public Animal() : base () {
        }
        public Animal(string nombre, string tipo,string categoria, string clase, string dieta) : base (clase , dieta)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.categoria = categoria;
        }
        //get
        public string getNombre() {return nombre;}
        public string getTipo() { return tipo; }
        public string getCategoria() { return categoria; }
        public int getEdad() { return edad; }
        public string getOrigen() { return origen; }
        //sett
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setTipo(string tipo) { this.tipo = tipo; }
        public void setCategoria(string categoria) { this.categoria = categoria; }
        public void setEdad(int edad) { this.edad = edad; }
        public void setOrigen(string origen) { this.origen = origen; }

        //métodos
        public Animal agregarMascotas()
        {
            Console.WriteLine("Agregue una mascota:\nNombre?: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Tipo?: ");
            string tipo = Console.ReadLine();
            Console.WriteLine("(Ejemplo: Salvaje / Domestico)Categoría?: ");
            string categoria = Console.ReadLine();
            Console.WriteLine("Clase?: ");
            string clase = Console.ReadLine();
            Console.WriteLine("Dieta?: ");
            string dieta = Console.ReadLine();
            Animal nuevaMascota = new Animal(nombre, tipo,categoria,clase,dieta);
            controlAnimal(nuevaMascota);
            return nuevaMascota;
        }
        public void controlAnimal(Animal nuevaMascota)
        {
            if (nuevaMascota.categoria == "Salvaje" || nuevaMascota.categoria == "salvaje")
            {
                string origen;
                Console.WriteLine("Origen?: ");
                origen = Console.ReadLine();
                nuevaMascota.origen = origen;
            }
            else
            {
                int edad;
                Console.WriteLine("Edad?: ");
                edad = int.Parse(Console.ReadLine());
                nuevaMascota.edad = edad;
            }
        }
        public override string ToString()
        {
            if (categoria=="Salvaje")
            {
                return "clase: " + getClase() + " dieta: " + getDieta() + " nombre: " + nombre + " tipo: " + tipo + " origen: " + origen;
            }
            else
            {
                return "clase: " + getClase() + " dieta: " + getDieta() + " nombre: " + nombre + " tipo: " + tipo + " edad: " + edad;
            }
            
        }
    }
}
