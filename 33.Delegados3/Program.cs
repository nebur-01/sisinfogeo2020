using System;

//Ejemplo de delegados multicast con parametros
namespace _33.Delegados3
{
    public delegate int MiDelegado(int a, int b); //Declara delegado recibe 2 parametos enteros
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d1 = A.MetodoA; //instancias
            MiDelegado d2 = B.MetodoB; // apuntan a dos metodos diferentes uno suma y otro  multiplica

            //Invocamos delegados de forma separada 
            Console.WriteLine($"La Suma           es {d1(10,20)}");
            Console.WriteLine($"La Multiplicación es {d2(10,20)}");
            Console.WriteLine();

            //Delegado multicast que une los 2 metodos
            MiDelegado d = d1 + d2;
            Console.WriteLine($"El resultado es {d(10,20)}"); //Regresa el resultado del ultimo metodo invocado
            Console.WriteLine();


            Console.WriteLine();
        }
    }

    public class A {
        public static int MetodoA(int a, int b)
        {
            return a + b;
        }
    }

    public class B {
        public static int MetodoB(int a, int b)
        {
            return a * b;
        }
    }
}
