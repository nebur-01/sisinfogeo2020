using System;
using System.IO;

namespace _14.CuentaBancaria
{
    [Serializable()]
    class Program{

      static void Inicializa(Banco banco){
            banco.AgregarCliente(new Cliente("Juan Isidro"));
            banco.AgregarCliente(new Cliente("Santiago Esparza"));
            banco.AgregarCliente(new Cliente("Juan Villa"));
            banco.AgregarCliente(new Cliente("Perla Velazco"));
            banco.AgregarCliente(new Cliente("Luis Fernando Cooper"));
            banco.AgregarCliente(new Cliente("Carlos Castañeda"));

            banco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(1000,0.5));
            banco.Clientes[0].AgregarCuenta(new CuentaDeCheques(1000,200));
            banco.Clientes[1].AgregarCuenta(new CuentaDeAhorro(2000,0.3));
            banco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(2000,0.3));
            banco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(5000,0.2));
            banco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(6000,0.2));
            banco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(5000,0.3));
            banco.Clientes[3].AgregarCuenta(new CuentaDeCheques(1200,300));
            banco.Clientes[5].AgregarCuenta(new CuentaDeCheques(120000,1300));
            banco.Clientes[5].AgregarCuenta(new CuentaDeAhorro(5000,0.6));
            banco.Clientes[4].AgregarCuenta(banco.Clientes[5].Cuentas[0]);
            banco.Clientes[5].Cuentas[0].Retira(90000);

      }

        static void Reporte(Banco banco){
            //Console.Clear();
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine($"{banco.Nombre}");
            Console.WriteLine("Reporte Mensual de Saldos");
            Console.WriteLine("_______________________________________________________");
            foreach(Cliente cte in banco.Clientes){
                Console.WriteLine($"{cte.Nombre}");
                foreach(CuentaBancaria cta in cte.Cuentas){
                    if(cta is CuentaDeAhorro)
                        (cta as CuentaDeAhorro).CalcularInteres();
                    Console.Write(cta is CuentaDeCheques?"Cheques:":"Ahorro:");  //if de corto circuito
                    Console.WriteLine(cta.Saldo);
                }
                Console.WriteLine($"Total Cuentas:{cte.Cuentas.Count}\n");
            }
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine($"Total Clientes: {banco.Clientes.Count}");
        }
       static void Main() {
                string archivo="datos";
                Banco mibanco=null;

                if(!File.Exists(archivo)) {
                    mibanco = new Banco("La Mina de Oro", "Rubén del refujio");
                    Inicializa(mibanco);
                    Util.Grabar(archivo, mibanco);
                    Console.WriteLine("--------- Datos Grabados --------------------\n");
 
                }else {
                    mibanco = new Banco();
                    Util.Cargar(archivo,ref mibanco);
                }


                Reporte(mibanco);

      }
    }
}
