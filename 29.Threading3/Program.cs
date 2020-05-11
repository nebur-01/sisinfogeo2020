using System;
using System.Threading;

namespace _29.Threading3
{
    class Imprimir {
        public void imprime(object o) {  //parametro tipo object
            lock(this) {                //para bloquear el codigo escencial que cada thread se ejecute de manera independiente
                for(int i=1; i<=10; i++) {
                    Thread.Sleep(100);
                    Console.WriteLine($"{o} - {i}");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir i = new Imprimir();
            Thread t1 = new Thread(i.imprime);
            Thread t2 = new Thread(i.imprime);

            //Inicio de cada Thread
            t1.Start(t1.ManagedThreadId);
            t2.Start(t2.ManagedThreadId);

            i.imprime(Thread.CurrentThread.ManagedThreadId);

        }
    }
}
