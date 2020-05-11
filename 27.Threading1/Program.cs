using System;
using System.Threading;

namespace _27.Threading1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombre del threading principal  (primer Hilo) 
            Thread.CurrentThread.Name="Principal";

            //Creación de los dos hilos o Thread (segundo y tercer Hilo)
            Thread t1 = new Thread(Imprime);
            Thread t2 = new Thread(Imprime);

            //Nombre de los dos thread que creamos
            t1.Name="Thread1";
            t2.Name="Thread2";

            //Se mandan llamar los thread (ejecución)
            t1.Start();
            t2.Start();

            //Invocamos Imprime desde Thread principal
            Imprime();

            Console.WriteLine("Saludos a travez del Main, se ha terminado todo");
        }

        static void Imprime () {
            for(int i=0; i<10; i++) {
                Console.WriteLine($"Imprime . {i} desde {Thread.CurrentThread.Name}");
                Thread.Sleep(100);
            }
        }
    }
}
