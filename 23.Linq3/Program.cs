using System;
using System.Collections.Generic;
using System.Linq;

namespace _23.Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> grupo = new List<Estudiante>();

        grupo.Add( new Estudiante {Id=1234,Nombre="Jose",
            Ciudad="Zacatecas",Calle="1a de Mayo",
            Cals=new List<int> {90,80,70,60}
            }
        );

        grupo.Add( new Estudiante {Id=5678,Nombre="Maria",
            Ciudad="Zacatecas",Calle="Felipe Angeles",
            Cals=new List<int> {80,70,90,80}
            }
        );

        grupo.Add( new Estudiante {Id=9101,Nombre="Osvaldo",
            Ciudad="Jerez",Calle="Garcia Salinas",
            Cals=new List<int> {70,90,70,80}
            }
        );

         grupo.Add( new Estudiante {Id=1213,Nombre="Pedro",
            Ciudad="fresnillo",Calle="Saucito",
            Cals=new List<int> {80,70,70,80}
            }
        );

        //Imprimir todos los datos
        Console.WriteLine("\nTodo de todo: \n");
        grupo.ForEach(est=>Console.WriteLine(est.ToString()));

        //Imprimir todos pero ordenados por nombre

        var q1 = ( from est in grupo orderby est.Nombre select est).ToList();
         Console.WriteLine("\nTodo ordenado por nombre: \n");
        q1.ForEach(est=>Console.WriteLine(est.ToString()));

        //Ordenar solo los de zacatecas

        var q2 = ( from est in grupo where est.Ciudad=="Zacatecas" select est).ToList();
        Console.WriteLine("\nNadamas los de Zacatecas: \n");
        q2.ForEach(Estudiante=>Console.WriteLine(Estudiante.ToString()));

        //El nombre de los estudiantes con promedio arriba de 80

        var q3 =
            ( from est in grupo 
            where est.Cals.Average()>80
            select new { nombre=est.Nombre, promedio=est.Cals.Average() }
            ).ToList();
        
        Console.WriteLine("\n Nombre y promedio de los mayores a 70\n");
        q3.ForEach(est=>Console.WriteLine($"Nombre:{est.nombre}, Promedio:{est.promedio}"));

        //agrupar por ciudad

        var q4 = from est in grupo group est by est.Ciudad;
        Console.WriteLine("\n Estudiantes agrupados por Ciudad\n");
        foreach(var ciudad in q4) {
            Console.WriteLine(ciudad.Key);
            foreach(var est in ciudad)
                Console.WriteLine(est.ToString());
        }



        }
    }
}
