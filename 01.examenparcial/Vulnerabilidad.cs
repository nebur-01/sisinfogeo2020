using System;

namespace _01.examenparcial{
      class Vulnerabilidades
    {
        private string clave;
        private string vendedor;
        private string descripcion;
        private string tipo;
        private string fecha;

        private double antiguedad;

        public Vulnerabilidades(string clave,string vendedor,string descripcion,string tipo,string fecha, double antiguedad)
        {
            this.clave=clave;
            this.vendedor=vendedor;
            this.descripcion=descripcion;
            this.tipo=tipo;
            this.fecha=fecha;
            this.antiguedad=antiguedad;

        }

        public string Clave{
            get{return clave;}
            set { clave = value;}
        }
        public string Vendedor{
            get{return vendedor;}
            set { vendedor = value;}
        }
        public string Descripcion{
            get{return descripcion;}
            set { descripcion = value;}
        }
        public string Tipo{
            get{return tipo;}
            set { tipo = value;}
        }
        public string Fecha{
            get{return fecha;}
            set { fecha = value;}
        }

        public double Antiguedad{
            get{return antiguedad;}
            set { antiguedad = value;}
        }
    }   
}