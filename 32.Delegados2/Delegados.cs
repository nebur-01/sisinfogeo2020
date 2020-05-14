using System;

namespace _32.Delegados2
{
    public class Delegados
    {
        public static void Mensaje1(string msj) {  //parametro que llega
            Console.WriteLine($"{msj} - Lleva el pastel");
        }

        public static void Mensaje2(string msj) {
            Console.WriteLine($"{msj} - fue el culpable se cancela la party");
        }
    }

}