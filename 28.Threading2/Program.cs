﻿using System;
using System.Threading;

namespace _28.Threading2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++) {
                Thread t = new Thread(Imprime);
                t.Start(i);
            }
        }

        static void Imprime(object o) {
            int s=0;
            for(int i=0; i<=500000; i++) {
                Console.WriteLine($"Imprime el Hilo {o} / {i}");
                s+=i;
            }
            Console.WriteLine($"Suma del Hilo {o} = {s}");
        }
    }
}
