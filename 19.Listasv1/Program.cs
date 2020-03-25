using System;
using System.Collections.Generic;

namespace _19.Listasv1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mats = new List<string>(){
                "Calculo I",
                "Redacción Avanzada",
                "Introducción a la Ingenieria"

            };

            //Agregar elementos a la list
            mats.Add("Matematicas Discretas");
            mats.Add("Compiladores e Interpretadores");

            Imprime(mats);

            string[] mopt = {
                "Sistemas de Info Geo (op)" ,
                "Seguridad en Redes (op)" ,
                "Topicos Selectos de Redes (op)"
            };
            mats.AddRange(mopt);
            Imprime(mats);

            //Invertir los elementos de la lista
            mats.Reverse();
            Imprime(mats);

            //ordenar la lista
            mats.Sort();
            Imprime(mats);

            //buscar un elemento en la lista, en base a una condicion
            Console.WriteLine("Buscar una materia que tenga la palabra Discretas");
            string mat = mats.Find(x=>x.Contains("Discretas"));
            Console.WriteLine(mat);

            //Buscar todas las ocurrencias en la lista, en base a una condicion
            Console.WriteLine("Buscar todas las materias que contengan (op)");
            var ms = mats.FindAll(x=>x.Contains("(op)"));
            Imprime(ms);
        }

        static void Imprime(List<string> lista) {
            Console.WriteLine("\n\n");
            foreach (string m in lista)
                Console.WriteLine(m);
            Console.WriteLine(lista.Count);
            {
                
            }
        }
    }
}
