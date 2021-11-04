using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Parcial_Prog3_CabreraIrina.IntentoNuevo
{
    class Horoscopo
    {
        //capricorio, acuario, piscis
        public DateTime[] signos = new DateTime[] { new DateTime(2020, 12, 21), new DateTime(2020, 1, 21), new DateTime(2020, 2, 21) };
        public int lugar = 0;
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
        public Horoscopo() {

        }
        public void foundSign(DateTime nacimiento)
        {
            DateTime nuevo = new DateTime();
            //por cada elelemtno de mi arreglo signos
            foreach (DateTime E in signos)
            {
                nuevo = E;
                lugar = lugar + 1;
                //voy a recorrer 30 dias despues de esa fecha
                for (int i = 0; i < 31; i++)
                {
                    //comparar mes
                    if (nacimiento.Month == nuevo.Month)
                    {
                        //comparar día
                        if (nacimiento.Day == nuevo.Day) {
                            Console.WriteLine("signo encontrado, su signo es: ");
                            controlarLugar();
                            break;
                        }
                    }
                    nuevo = nuevo.AddDays(1.0);
                }
            }
        }

        public void controlarLugar()
        {
            switch (lugar)
            {
                case 1:
                    Console.WriteLine("Capricornio");
                    break;
                case 2:
                    Console.WriteLine("Acuario");
                    break;
                case 3:
                    Console.WriteLine("Piscis");
                    break;
                default:
                    Console.WriteLine("Opción no contemplada");
                    break;
            }
        }

        public string prediccion(DateTime nacimiento, DateTime hoy)
        {
            foundSign(nacimiento);
            return "";
        }
    }
}
