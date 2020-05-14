using System;

//Delegado Multicast
namespace _32.Delegados2
{
    //Declaración de Delegado
    public delegate void MiDelegado(string msj);
    class Program
    {
        static void Main(string[] args)
        {
            // Se declaran 3 delegados
            MiDelegado d1;
            MiDelegado d2;
            MiDelegado d3;

            MiDelegado d;  // Se declara delegado Multicast

            Console.Clear();

            //Se asocia d1 a Mensaje1 y d2 a Mensaje2
            d1 = Delegados.Mensaje1;
            d2 = Delegados.Mensaje2;

            d = d1 + d2; //Combina delegado d1 y delegado d2 en d
            d("El Peje");
            Console.WriteLine();

            d3 = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta"); //función tipo lambada
            d += d3; //Agrega delegado d3
            d("El Borolas");
            Console.WriteLine();

            d -= d2; //Quita el delegado d2
            d("Peña");
            Console.WriteLine();

            d -= d1; //QUita el delegado d1
            d("Tello");
            Console.WriteLine();
        }
    }
}
