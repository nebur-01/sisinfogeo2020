using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            empleado empleado01 = new empleado();

            empleado empleado02;
            empleado02 = new empleado();

            empleado empleado03 = new empleado("María", 30);

            empleado01.Nombre = "Juan Camanei";
            empleado01.Edad   = 25;




            Console.WriteLine($"Nombre {empleado01.Nombre}, edad: {empleado01.Edad}");
            Console.WriteLine(empleado01.ToString());

            Console.WriteLine($"Te iras de vacaciones la siguiente fecha: {DateTime.Now.ToString("dd/MM/yy")}");
            Console.WriteLine($"Regresas:  {empleado01.Vacaciones(DateTime.Now, 30)}");
        }
    }
}
