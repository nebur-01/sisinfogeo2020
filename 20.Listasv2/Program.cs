using System;
using System.Collections.Generic;

namespace _20.Listasv2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una lista de tipo pieza
           List<Pieza> mp = new List<Pieza>();
        
          //Agregar elementos a la lista
           mp.Add( new Pieza(1234,"Tuerca de rosca interior"));
           mp.Add( new Pieza(5678,"Tornillo cabeza grande"));
           mp.Add( new Pieza(9345,"Bateria de 12 v"));

           //Agregar un rango de elementos
           var proveedor = new List<Pieza>() {
               new Pieza(8888,"Tornillo de cabeza pequeña"),
               new Pieza(9999,"Cables para pasar corriente"),
               new Pieza(6666,"Tridente del diablo")
           };
           mp.AddRange(proveedor);

            //usar el metodo foreach integrado en la lista para imprimir su contenido
            mp.ForEach(p=>Console.WriteLine(p.ToString())); 

            //eliminar el ultimo elemento de la lista
            mp.RemoveAt(mp.Count-1);  

            //insertar un elemento en la segundo posición
            Console.WriteLine("Insertar un elemento en la pisición 2");
            mp.Insert(1, new Pieza(2222, "Caja de 8 Velocidades"));  
             mp.ForEach(p=>Console.WriteLine(p.ToString()));  

             //Buscar todas las piezas que tengan la palabra tornillo 
             Console.WriteLine("PiezaS que contienen tornillo"); 
             var t=mp.FindAll(x=>x.Nombre.Contains("Tornillo"));
             t.ForEach(p=>Console.WriteLine(p.ToString()));  

             //Buscar todas las piezas cuyo ID es menor que 5000

             Console.WriteLine("Piezas con id > 5000"); 
             var t1=mp.FindAll(x=>x.Id>5000);
             t1.ForEach(p=>Console.WriteLine(p.ToString()));


        }
    }
}
