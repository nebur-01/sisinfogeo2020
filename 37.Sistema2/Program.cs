using System;
using System.Net.NetworkInformation;
using System.Net;
using System.Diagnostics;


namespace _37.Sistema2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Procesamos argumentos del usuario 
            if( args.Length < 1 ) Menu();
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                switch(int.Parse(args[0])) {
                    case 1: Ping("www.uaz.edu.mx"); break;
                    case 2: DnsAndIPLocal(); break;
                    case 3: InterfacesRed(); break;
                    default: Console.WriteLine("Opción Invalida ..."); break;
        }
        Console.ForegroundColor = ConsoleColor.Black;
      }
    }

    static void Menu() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[-] Menú de opciones, operaciones de red \n");
            Console.WriteLine("[-] Hacer ping a uaz.edu.mx ....................... [1]");
            Console.WriteLine("[-] Obtener nombre host e ip de mi PC ............. [2]");
            Console.WriteLine("[-] Obtener interfaces de red de mi PC ............ [3]");
            Console.ForegroundColor = ConsoleColor.Black;
    }

//
    static void Ping(string ipaddr) {  
        Ping ping = new Ping();
        Console.WriteLine("Haciendo ping a uaz.edu.mx");
        PingReply reply = ping.Send(ipaddr,1000); //analiza la respuesta 
        Console.WriteLine($"Respuesta: {reply.Status.ToString()}");
    }

    static void DnsAndIPLocal() {
        string hostname = Dns.GetHostName();
        string ip = Dns.GetHostEntry(hostname).AddressList[0].ToString();
        Console.WriteLine($"Nombre del host : {hostname}");
        Console.WriteLine($"Ip del host     : {ip}");
    }

    static void InterfacesRed()
    {
        NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces(); //
        Console.WriteLine($"Interfaces Wireless o Ethernet:");
        foreach(NetworkInterface interfaz in interfaces)  //arreglo NetworkInterface
        {
            if(interfaz.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                interfaz.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    Console.Write($"{interfaz.Id.ToString(),-8}");
                    Console.Write($"{interfaz.NetworkInterfaceType.ToString(),-10}");
                    Console.Write($"{interfaz.GetPhysicalAddress().ToString(),-13}");
                    UnicastIPAddressInformationCollection uniIps = interfaz.GetIPProperties().UnicastAddresses;
                    foreach(UnicastIPAddressInformation ip in uniIps)
                        Console.Write($"{ip.Address.ToString(),-30}");
                    Console.WriteLine();
                }

        }
    }
  }
}
