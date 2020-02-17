using System;
namespace ej1{

    class empleado{
        //Método
        //miembros de la clase
        private string nombre;
        private int edad;

        //Constructores
        public empleado(){
            

        }

        public empleado(string nombre, int edad){
            this.nombre=nombre;
            this.edad=edad;
        }

        //propiedades de la clase utiles para enviar y recibir valores

        public string Nombre {
            get { return nombre;}
            set {nombre = value;}
        }

        public int Edad {
            get { return edad;}
            set {edad = value;}
        }


        //metodos de la clase

        public string Vacaciones(DateTime ini, int dias){
            DateTime fin;
            fin=ini.AddDays(dias);
            return fin.ToString("dd/MM/yy");
        }

    //sobrecargamos el metodo ToString eredado de la clase Base {object}
        public override string ToString() {
            return $"Nombre {nombre} Edad: {edad}";
        }
        
        
    }

}
