using System;
using System.Collections.Generic;
using System.Text;

namespace Barrio
{
    class Persona
    {
        private string nombre;
        private char sexo;
        private int edad;
        private string fecNac;
        private string rol;
        private string trabajo;
        private int grado;

        public Persona() { }
        public Persona(string nombre, char sexo, int edad, string fechNac, string rol)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
            this.fecNac = fechNac;
            this.rol = rol;
        }
        public Persona agregarPersona()
        {
            Console.WriteLine("Agregue una persona:\nNombre?: ");
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
            controlPersona(nuevaPersona);
            return nuevaPersona;
        }
        public void controlPersona(Persona nuevaPersona)
        {
            string trabajo; int grado;
            if (nuevaPersona.rol == "Padre")
            {
                Console.WriteLine("trabajo?: ");
                trabajo = Console.ReadLine();
                nuevaPersona.trabajo = trabajo;
            }
            else
            {
                Console.WriteLine("grado de escuela?: ");
                grado = int.Parse(Console.ReadLine());
                nuevaPersona.grado = grado;
            }
        }
        
        //get
        public string getNombre(){ return nombre; }
        public int getEdad(){return edad;}
        public string getrRol(){return rol;}
        public string getTrabajo(){return trabajo;}
        public int getGrado(){return grado;}
        //set
        public void setNombre(string nombre){this.nombre = nombre;}
        public void setEdad(int edad){this.edad = edad;}
        public void setTrabajo(string trabajo){this.trabajo = trabajo;}
        public void setRol(string rol){this.rol = rol;}
        public void setGrado(int grado){this.grado = grado;}
        public override string ToString()
        {
            if (rol== "Padre")
            {
                return "Nombre: " + nombre + " Edad: " + edad + " Trabajo: " + trabajo;
            }
            else
            {
                return "Nombre: " + nombre + " Edad: " + edad + " Grado: " + grado;
            }
            
        }
    }
}
