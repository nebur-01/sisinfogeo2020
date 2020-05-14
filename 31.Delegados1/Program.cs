using System;

namespace _31.Delegados1
{
    //Declaración de delegados
    public delegate void MDelegado(string msj);  //Palabra reservada delegate y firma a partir del void en adelante
    class Program
    {
        static void Main(string[] args)
        {
            MDelegado d; //se crea instancia del delegado

            Console.Clear();

            //Delegado invoca al metodo Mensaje1 de la clase Mensajes
            d = Mensajes.Mensaje1; 
            d("Juan");

            //Delegado invoca al metodo Mensaje2 de la clase Mensajes
            d = Mensajes.Mensaje2;
            d("Pedro");

            //Delegado invoca a una expresión lambada
            d = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            d("Carlos");
        }
    }

    public class Mensajes {
        public static void Mensaje1(string msj) {
            Console.WriteLine($"{msj} - lleva el pastel");
        }
        public static void Mensaje2(string msj) {
            Console.WriteLine($"{msj} - fue el culpable se cancela la fiesta");
        }
    }
}
