﻿using System;

namespace _14.CuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria chelines = new CuentaBancaria(1000);
            Console.WriteLine($"Saldo al crear cuenta {chelines.Saldo}");
            chelines.Saldo=500;
            Console.WriteLine($"Saldo despues del domingo: {chelines.Saldo}");
            if(chelines.Retira(600))
                    Console.WriteLine($"Saldo despues de la peda {chelines.Saldo}");
            else
                    Console.WriteLine("No puedes andar organizando fiesta compa, si no tienes los recursos");
            
        
        }
    }
}
