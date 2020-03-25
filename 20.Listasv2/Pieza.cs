using System;

namespace _20.Listasv2{
    class Pieza {

        //Constructor 
        public Pieza(int id, string nombre) => (Id,Nombre)=(id,nombre);
        public int Id {get; set;}
        public string Nombre {get; set;}

        //sobrecargar el metodo ToString
        public override string ToString() => $"{Id} - {Nombre}";
    }
}