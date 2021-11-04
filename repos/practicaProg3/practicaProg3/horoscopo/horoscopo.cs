using System;
using System.Collections.Generic;
using System.Text;

namespace practicaProg3.horoscopo
{
    class horoscopo
    {
        public string[] amor = new string[]
        {
            "No temas poner punto final a esa relación que te trae solo dolores de cabeza. ",
            "Hoy es el día indicado para decir basta.",
            "Te sorprenderá saber que tu pareja está pensando en la descendencia.",
            "Nunca podrás alcanzar una vida sin problemas o vicisitudes.",
            "Lo importante es darle al amor el lugar que merece en ella.",
            "Harás entender a tu pareja que necesita poner su granito de arena para hacer funcionar la relación." };
        public string[] dinero = new string[]
        {
            "Momento de suerte en los negocios.",
            "El lucrativo Júpiter te trae un dinero extra este mes.",
            "No es menor saber de dónde proviene porque quizás no quieras tomarlo.",
            "Sufrirás grandes desilusiones en ciertos proyectos en los que habías invertido mucho tiempo.",
            "Lograrás dejar claro en tu ambiente laboral que no eres el tipo de persona que tolera abusos.",
            "Entrarás en pánico al ver que se está volviendo imposible cumplir con tus fechas límites.",
        };
        public string[] bienestar = new string[]
            {
                "Cuestiónate hasta dónde te dejarás llevar con tu grupo de trabajo.",
                "No puedes permanecer con rencor por disputas que vivieras con tus seres queridos hace tiempo.",
                "Una persona sabia como tú debe saber su cuerpo y su alma.",
                "Aprende de tus vivencias o estarás condenado a repetirlas.",
                "Presta atención a cada paso que das y vivirás una vida más plena y libre de escollos.",
                "La clave del éxito reside en la forma en la cual administras los recursos a tu alcance.",
            };
        public DateTime[] signosInicio = {new DateTime(2020,03,21), new DateTime(2020,04,21), new DateTime(2020,05,21) };//aries, tauro, geminis 
        public DateTime[] signosFinal = { new DateTime(2020, 04, 20), new DateTime(2020, 05, 20), new DateTime(2020, 06, 20) };

        
        public void averiguarSigno(DateTime fecha, usuario nuevoUsuario)
        {
            int contSignosFinal = 0;//este me controla que se efectue bien al fecha de fin del arreglo
            foreach (DateTime item in signosInicio)
            {

                for (DateTime i = item; i < signosFinal[contSignosFinal]; i=i.AddDays(1))
                {
                    if (fecha.CompareTo(i) == 0)
                    {
                        switch (contSignosFinal)
                        {
                            case 0:
                                nuevoUsuario.setSigno("Aries");
                                nuevoUsuario.setPeso(100);
                                break;
                            case 1:
                                nuevoUsuario.setSigno("Tauro");
                                nuevoUsuario.setPeso(200);
                                break;
                            case 2:
                                nuevoUsuario.setSigno("Geminis");
                                nuevoUsuario.setPeso(300);
                                break;
                            default:
                                Console.WriteLine("algo pasó acá");
                                break;
                        }
                    }
                }
            }
        }

        public void prediccion(usuario nuevoUsuario)
        {
            int numeroSemana = 0;
            
            
            DateTime hoy = DateTime.Now;
           
            //para saber en que numero de semana estamos:
            for (DateTime i = new DateTime(2020,01,01); i<=hoy; i=i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Monday)
                {
                    numeroSemana += 1;
                }
            }

            
            Random random = new Random(nuevoUsuario.getPeso()+numeroSemana); //semillaPuesta

            //amor
            Console.WriteLine("En EL AMOR: ");
            for (int i = 0; i < 1; i++)
            {
                int index = random.Next(amor.Length);
                Console.WriteLine(amor[index]);
            }
            //dinero
            Console.WriteLine("En EL DINERO: ");
            for (int i = 0; i < 1; i++)
            {
                int index = random.Next(dinero.Length);
                Console.WriteLine(dinero[index]);
            }
            //bienestar
            Console.WriteLine("En LA SALUD o BIENESTAR: ");
            for (int i = 0; i < 1; i++)
            {
                int index = random.Next(bienestar.Length);
                Console.WriteLine(bienestar[index]);
            }
        }
    }
}
