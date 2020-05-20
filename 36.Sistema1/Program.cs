using System;
using System.Diagnostics;
using System.Linq;
using System.Collections;

namespace _36.Sistema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Procesamos los argumentos que pasamos al programa
            if( args.Length < 1 ) Menu();
            else {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                switch(int.Parse(args[0])) {
                    case 1: InfoSistema(); break;
                    case 2: Procesos(); break;
                    case 3: ProcesoActual(); break;
                    case 4: HilosyModulos(int.Parse(args[1])); break;
                    default: Console.WriteLine("Opción Invalida ..."); break;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void Menu() {
            //Opciones
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[-] Menú: Procesos, Hilos, Modulos \n");
            Console.WriteLine("[-] Información del Sistema ....................... [1]");
            Console.WriteLine("[-] Visualizar procesos del sistema ............... [2]");
            Console.WriteLine("[-] Visualizar el proceso actual .................. [3]");
            Console.WriteLine("[-] Ver Hilos y Modulos de un proceso dado ........ [4]");
            Console.ForegroundColor = ConsoleColor.Black;

        }

        static void InfoSistema() {
            //Obtener informacion del sistema
            Console.WriteLine($"Numero de Procesadores : {Environment.ProcessorCount}");
            Console.WriteLine($"Usuario Actual         : {Environment.UserName}");
            Console.WriteLine($"Dot Net.Core Versión   : {Environment.Version}");
            Console.WriteLine($"Versión de SO          : {Environment.OSVersion}");
            Console.WriteLine($"Nombre de la Maquina   : {Environment.MachineName}");
            Console.WriteLine($"Sistema es 64bits      : {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Directorio Actual      : {Environment.CurrentDirectory}");
            Console.WriteLine($"Unidades Logicas       : {Environment.GetLogicalDrives().Count()}");
            foreach(string drv in Environment.GetLogicalDrives()) Console.Write($"{drv}  ");  //para desplegar
            Console.WriteLine($"\n Variables de entorno  : {Environment.GetEnvironmentVariables().Count}");
            foreach(DictionaryEntry var in Environment.GetEnvironmentVariables()) Console.Write($"{var.Key,-35} = {var.Value}\n");
        }

        static void Procesos() {
            //Obtener y listar todos los procesos del sistema
            var procesos = (from proc in Process.GetProcesses() orderby proc.ProcessName select proc).ToList();
            Console.WriteLine($"Procesos del sistema : {procesos.Count}");
            procesos.ForEach(p => Console.WriteLine($"{p.Id} {p.ProcessName}"));
            Console.WriteLine();
        }

        static void ProcesoActual() {
            //Obtener y listar el proceso actual
            var pa = Process.GetCurrentProcess();
            Console.WriteLine("El proceso que se ejecuta actualmente :");
            Console.WriteLine($"{pa.Id} {pa.ProcessName} {pa.StartTime}\n");
        }

        static void HilosyModulos(int proceso) 
        {
            //obtener los Threads y Modulos de un proceso
            //dependera de los procesos listados en tu sistema en particular
            try
            {

                //Obtener proceso por ID
                Process pr = Process.GetProcessById(proceso);
                Console.WriteLine("\nInformación de un proceso:");
                Console.WriteLine($"{pr.Id} {pr.ProcessName}");

                //Obtener hilos del proceso en cuestión 
                ProcessThreadCollection hilos = pr.Threads;
                Console.WriteLine($"\n>> Hilos en este proceso:{hilos.Count}");
                foreach(ProcessThread hilo in hilos) {   // listar
                    Console.WriteLine($"{hilo.Id} {hilo.ThreadState} {hilo.StartTime} {hilo.PriorityLevel}");
                }

                //modulos 
                ProcessModuleCollection modulos = pr.Modules;
                Console.WriteLine("\n>> Modulos del proceso:");
                foreach(ProcessModule mod in modulos) {
                    Console.WriteLine($"{mod.ModuleName}");
                }

            }
        
            catch (ArgumentException err)  // no se desborde el programa
            {
            Console.WriteLine(err.Message);
            }

         }
    }
}
