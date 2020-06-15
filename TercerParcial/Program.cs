using System;
using System.Collections.Generic;

namespace TercerParcial
{
    class Program{
        static void Main(string[] args)
        {
            if(args.Length < 1) Menu();
            else{
            switch(int.Parse(args[0])){

                case 1:
                Console.WriteLine("1 Miembros de solo lectura");
                    Papeleria papeleria  = new Papeleria();
                    papeleria.id = 1;
                    papeleria.nombre = "La Escuelita";
                    papeleria.antiguedad = 7.5F;
                    papeleria.Colonia = "Gecaloca";
                    papeleria.iva = 120;

                    Papeleria papeleria2  = new Papeleria();
                    papeleria2.id = 2;
                    papeleria2.nombre = "La Pape";
                    papeleria2.antiguedad = 12;
                    papeleria.Colonia = "Iturbide";
                    papeleria.iva = 107;

                    Console.WriteLine(papeleria.ToString());
                    Console.WriteLine(papeleria2.ToString());
                    break;
                case 2:
                Console.WriteLine("2 Expresiones switch");
                   string Disponible = ArticulosVarios(Articulos.Acuarelas);
                   Console.WriteLine(Disponible);
                   break;
                case 3:
                Console.WriteLine("3 Patrones de tupla");
                    string Turno = TurnoEmpleados(3,"Juan");
                    Console.WriteLine(Turno);
                    break;
                case 4:
                Console.WriteLine("4 Patrones posicionales");
                    OfertasArticulo art = new OfertasArticulo(2,1);
                    Console.WriteLine(GetQuadrant(art));
                    break;
                case 5:
                Console.WriteLine("5 Declaraciones Using");
                   IEnumerable<string> mensaje = new string[] {"S","e","r","v","i","c","i","o","s"};
                   DeclaracionUsing(mensaje);
                    Console.WriteLine();
                    break;
                case 6:
                Console.WriteLine("6 Funciones locales estáticas");
                    Console.WriteLine(Sueldo());
                    Console.WriteLine(Gastos());
                    break;
                case 7: IndRang(); break; 
                
                case 8: 
                Console.WriteLine("8 Patrones de propiedades");
                PatronesProp(); break;
                

               default: Console.WriteLine("Opción No Valida"); break;   
            }
        }
     }

        static void Menu(){
            Console.WriteLine("Caracteristicas nuevas en C# V8.0");
            Console.WriteLine("1.- Miembros de solo lectura");
            Console.WriteLine("2.- Expresiones switch");
            Console.WriteLine("3.- Patrones de tupla");
            Console.WriteLine("4.- Patrones posicionales");
            Console.WriteLine("5.- Declaraciones Using");
            Console.WriteLine("6.- Funciones locales estáticas");
            Console.WriteLine("7.- Indices y rangos");
            Console.WriteLine("8.- Patrones de propiedades");
        }

        
        public struct Papeleria{
            public int id {get; set;}
            public string nombre {get; set;}
            public float antiguedad {get; set;}
            public string Colonia{get; set;}
            public float iva {get; set;}

            public readonly override string ToString(){
                return $"La papeleria con ID:{id}, tiene variedad de productos y tiene como Nombre: {nombre} ya que cuenta con Antiguedad de: {antiguedad} años";
            }
        }
    

        public enum Articulos{
            Lapiz,Calculadora,Acuarelas,Borrador,Colores,Pluma
        }

        public static string ArticulosVarios(Articulos articulosdisponible) => articulosdisponible switch
        {
            Articulos.Lapiz => "Disponible",
            Articulos.Calculadora => "Disponible",
            Articulos.Acuarelas => "No Disponible",
            Articulos.Borrador => "Disponible",
            Articulos.Colores => "No Disponible",
            Articulos.Pluma => "Disponible",
            _ => "No existe ese articulo",
        };

        public static string TurnoEmpleados(int Id, string Nombre) =>
            (Id, Nombre) switch{
                (1, "Enrique") => "Matutino",
                (2, "Yesenia") => "Intermedio",
                (3, "Juan") => "Vespertino",
                _ => "Descanso",
            };
        

        public class OfertasArticulo{
            
            public int A { get; }
            public int B { get; }

            public OfertasArticulo(int a, int b) => (A, B) = (a, b);

            public void Deconstruct(out int a, out int b) =>
                (a, b) = (A, B);
        }

        public enum OfertasQuadrant{
            Lapíz,Acuarelas,Borrador,Colores,Precio,SinOferta
        }

        static OfertasQuadrant GetQuadrant(OfertasArticulo tra) => tra switch{
            (0, 0) => OfertasQuadrant.Precio,
            var (a, b) when a < 3 && b < 2 => OfertasQuadrant.Lapíz,
            var (a, b) when a > 7 && b < 10 => OfertasQuadrant.Acuarelas,
            var (a, b) when a > 15 && b < 19 => OfertasQuadrant.Borrador,
            _ => OfertasQuadrant.SinOferta
        };

        static void IndRang(){
            Console.WriteLine(" 8  Indices y rangos ");
	var NombresEmpleados = new string[]
	{
		"Juan",
		"Enrique",
		"Yesenia",
		"Pedro",
		"Osvaldo",
		"Lilia",
		"Angel"
    	};
	Console.WriteLine($"El tercer empleado que ingreso a trabajar es: {NombresEmpleados[^4]}");
	Console.WriteLine($"El ultimo empleado que ingreso a trabajar es: {NombresEmpleados[^1]}");

}

        public static int Sueldo(){
            int sueldoQuincenal;
            LocalFuntion();
            return sueldoQuincenal;
            void LocalFuntion() => sueldoQuincenal = 170*15;
        }

        public static int Gastos(){
            int Luz = 300;
            int Internet = 400 ;
            return Add(Luz,Internet);
            static int Add(int limpieza, int comidasem) => limpieza + comidasem;
        }


        static int DeclaracionUsing(IEnumerable<string> lines){
            using var file = new System.IO.StreamWriter("Mensaje.txt");
            int skippedLines = 0;
            foreach (string line in lines){
                if (!line.Contains("Rubén")){
                    file.WriteLine(line);
                }else{
                    skippedLines++;
                }
            }
            return skippedLines;
        
        }


    static void PatronesProp(){
     {
        Papeleria papeleria = new Papeleria();
        switch (papeleria.Colonia)
        {
            case "Centro": 
            Console.WriteLine($"Impuestos : {papeleria.iva*1.2F}"); 
            break;

            case "Iturbide":
            Console.WriteLine($"Impuestos : {papeleria.iva*1.5F}"); 
            break;


        }
        
     }; 
   }

 }
    
}
