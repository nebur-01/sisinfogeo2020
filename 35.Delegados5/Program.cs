using System;

namespace _35.Delegados5
{
    public delegate void MiDelegado(string msj);
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado del; //Se crea instancia de MiDelegado

            Console.Clear();

            del = ClaseA.MetodoA; // se va a asociar el metodoA al delegado
            Invocadelegado(del); //se invoca al delegado

            del = ClaseB.MetodoB;
            Invocadelegado(del); //se invoca delegado

            del = (string msj) => Console.WriteLine($"Llamando expresión Lambada: {msj}");
            Invocadelegado(del); //se invoca delegado

            Console.WriteLine();
        }

        //Este método recibe como parámetro un delegado
        static void Invocadelegado(MiDelegado del) {
            del("Hola Mundo"); //se invoca delegado
        }
    }

        class ClaseA {
            public static void MetodoA(string msj) {
                Console.WriteLine($"Llamando MetodoA de ClaseA : {msj}");
            }
        }

        class ClaseB {
            public static void MetodoB(string msj) {
                Console.WriteLine($"Llamando MetodoB de ClaseB : {msj}");
            }
        }
}

