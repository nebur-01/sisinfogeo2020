using System;

namespace _34.Delegados4
{
    public delegate T Suma<T>(T param1, T param2); //Declara delegado generico declarados de tipo T
    class Program
    {
        static void Main(string[] args)
        {
            Suma<int> d1 = Sumar; //Delegado al metodo Sumar de tipo int con parametros int,int
            Console.WriteLine( d1(10,20) );

            Suma<string> d2 = Concatenar; //Delegado al metodo Concatenar de tipo string con parametros string,string
            Console.WriteLine( d2("Mi Mama me"," mima mi Mama") );

            Console.WriteLine();
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static string Concatenar(string a, string b)  //2 Parametros
        {
            return a + b;
        }
    }
}
