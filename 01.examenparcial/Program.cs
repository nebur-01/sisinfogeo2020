using System;

namespace _01.examenparcial
{
    class Program
    {
       
        static void Inicializa(Red red){
                red.AgregarNodo(new Nodo("192.168.0.10","Servidor",5,10,"Kali linux"));
                red.AgregarNodo(new Nodo("192.168.0.12","Equipoactivo",2,12,"IOS"));
                red.AgregarNodo(new Nodo("192.168.0.20","Computadora",8,5,"Windows"));
                red.AgregarNodo(new Nodo("192.168.0.15","Servidor",10,22,"Ubuntu linux")); 

                red.Nodos[0].AgregarVulne(new Vulnerabilidades("CVE-2015-1635","Microsoft"," HTTP.sys permite a atacantes remotos ejecutar código arbitrario","remota","04/14/2015",3));
                red.Nodos[0].AgregarVulne(new Vulnerabilidades("CVE-2017-0004","Microsoft","El servicio LSASS permite causar una denegación de servicio","local"," 01/10/2001", 1));   
                red.Nodos[1].AgregarVulne(new Vulnerabilidades("CVE-2017-3847","Cisco","Cisco Firepower Management Center XSS","remote","02/21/2017",1));
                red.Nodos[2].AgregarVulne(new Vulnerabilidades("CVE-2009-2504","Microsoft","Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1","local","11/13/2009",9));
                red.Nodos[2].AgregarVulne(new Vulnerabilidades("CVE-2016-7271","Microsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold","local","12/20/2016",2));
                red.Nodos[2].AgregarVulne(new Vulnerabilidades("CVE-2017-2996,","Adobe","Adobe Flash Player 24.0.0.194 corrupción de memoria explotable","remota","15/02/2017",1));
               



        }
        static void Reporte(Red red)
        {
                Console.Clear();
                int n=0,mayor=0,menor=0;
                Console.WriteLine("-------------------------------");
                Console.WriteLine(">> Datos generales de la red: \n");
                Console.WriteLine($"Empresa: {red.Empresa}\nPropietario: {red.Propietario}\nDomicilio: {red.Domicilio}");
                Console.WriteLine($"Total de Nodos de red:{red.Nodos.Count}");
                foreach(Nodo nd in red.Nodos)
                    n+=nd.Vulnera.Count;
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Total vulnerabilidades:{n}\n");
                 Console.WriteLine("** Datos generales de los nodos:\n");
                
                foreach(Nodo no in red.Nodos)
                    if (no.Saltos>mayor)
                    {
                        mayor=no.Saltos;
                    }else
                    {
                        menor=no.Saltos;
                    }
                Console.WriteLine($"\nNumero mayor de saltos:{mayor}");    
                Console.WriteLine($"Numero menor de saltos:{menor}\n");  

           foreach(Nodo cte in red.Nodos){
                 Console.WriteLine($"Ip: {cte.Ip}, Tipo: {cte.Tipo}, Puertos: {cte.Puertos}, Saltos: {cte.Saltos}, So: {cte.So}, TotVul: {cte.Vulnera.Count}");
                foreach(Vulnerabilidades vul in cte.Vulnera){
                     Console.WriteLine("---------------------------------");
                     Console.WriteLine("\n Vulneravilidades: ");
                     Console.WriteLine($"Clave: {vul.Clave}\n Vendedor: {vul.Vendedor} \n Descripción: {vul.Descripcion} \n Tipo: {vul.Tipo} \n Fecha: {vul.Fecha} \n Antigüedad: {vul.Antiguedad}");
                }
                
            }

                               
        }
        static void Main()
        {
            Red miRed =new Red("Red Datanet, S.A. de C.V.","Mr Uriel Ramirez","Av. Mexico 27, Zacatecas Zacatecas");
            Inicializa(miRed);
            Reporte(miRed);
        }
    }
}
