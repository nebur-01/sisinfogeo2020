using System;
using System.IO; // Libreria para StreamREader y StreamWriter
using CsvHelper; // Libreria para trabajar con archivos cvs
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _2.ExamenParcial
{
    class Program
    {
        static void Main(String[] args)
        {
            // Importar archivo csv en la clase Empleados

            List<Empleado> datos = new List<Empleado>();
            datos=Leer("datos.csv");


            // Agregar datos adicionales

            datos.Add(new Empleado {Rfc="CARC771123",Nombre="CARLOS CASTANEDA RODRIGUEZ",Area="JUBILADOS",Salario=5456.66});
            datos.Add(new Empleado {Rfc="SOBR711202",Nombre="ROCIO SOTO BOTELLO",Area="JUBILADOS",Salario=6423.66});
            datos.Add(new Empleado {Rfc="SUGA791124",Nombre="ARACELI SUSTAITA GOMEZ",Area="PROMOCION",Salario=2380});
            datos.Add(new Empleado {Rfc="DEAM690813",Nombre="MARGARITA DELGADILLO ARCE",Area="PROMOCION",Salario=1858});
            datos.Add(new Empleado {Rfc="PETT670521",Nombre="PEREZ TORRES MARIA TRINIDAD",Area="PROMOCION",Salario=1851});
            datos.Add(new Empleado {Rfc="ROLE771004",Nombre="ERIKA FRANCISCA ROBLES LOPEZ",Area="JUBILADOS",Salario=4691.44});
            datos.Add(new Empleado {Rfc="LERK911214",Nombre="KARELY GUADALUPE LEAL RAMOS",Area="DEPORTE",Salario=1223.66});
            datos.Add(new Empleado {Rfc="BEAY911116",Nombre="YESICA BERUMEN ACOSTA",Area="CULTURA",Salario=6423.66});
            datos.Add(new Empleado {Rfc="GABY912217",Nombre="YAZMIN GARCIA BAEZ",Area="DEPORTE",Salario=2421.12});

            // Grabar todos los datos en un archivo llamado nomina.csv

            Grabar(datos,"nomina.csv");

            Console.WriteLine("Listado de nómina orden original......... [1]");
            Console.WriteLine("Listado de nómina ordenado por nombre ... [2]");
            Console.WriteLine("Listado de nómina ordenado por salario .. [3]");
            Console.WriteLine("Listado de nómina con salario > 3500 .... [4]");
            Console.WriteLine("Listado de nómina con 77 en el RFC....... [5]");
            Console.WriteLine("Listado de nómina con los JUBILADOS...... [6]");
            Console.WriteLine("Listado de nómina agrupado por area...... [7]\n\n");

            if(args[0] == "1"){
            Console.WriteLine("Listado de nómina orden original:");
            List<Empleado> datos2 = new List<Empleado>();
            datos2=Leer("nomina.csv");

            datos2.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {datos2.Count}");}
            else if(args[0] == "2"){
            Console.WriteLine("Listado de nómina ordenado por nombre:\n");
            List<Empleado> datos3 = new List<Empleado>();
            datos3=Leer("nomina.csv");

            datos3.Sort((p, q) => string.Compare(p.Nombre, q.Nombre));
            datos3.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {datos3.Count}");}
            else if(args[0] == "3"){
            Console.WriteLine("Listado de nómina ordenado por salario:\n");
            List<Empleado> datos4 = new List<Empleado>();
            datos4=Leer("nomina.csv");

            var q1 = (from emp in datos4 orderby emp.Salario select emp).ToList();  
            q1.Reverse();
            q1.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {datos4.Count}");}
            else if(args[0] == "4"){
            Console.WriteLine("Listado de nómina con salario > 3500:\n");
            List<Empleado> datos5 = new List<Empleado>();
            datos5=Leer("nomina.csv");

            var q1 = (from emp in datos5 where emp.Salario > 3500 select emp).ToList();  
            q1.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q1.Count}");}
            else if(args[0] == "5"){
            Console.WriteLine("Listado de nómina con 77 en el RFC:\n");
            List<Empleado> datos6 = new List<Empleado>();
            datos6=Leer("nomina.csv");

            var q1 = (from emp in datos6 where emp.Rfc.Contains("77") select emp).ToList();  
            q1.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q1.Count}");}
            else if(args[0] == "6"){
            Console.WriteLine("Listado de nómina con los JUBILADOS:\n");
            List<Empleado> datos7 = new List<Empleado>();
            datos7=Leer("nomina.csv");

            var q1 = (from emp in datos7 where emp.Area.Contains("JUBILADOS") select emp).ToList();  
            q1.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q1.Count}");}
            else if(args[0] == "7"){
            Console.WriteLine("Listado de nómina agrupado por area:\n");
            List<Empleado> datos8 = new List<Empleado>();
            datos8=Leer("nomina.csv");

            Console.WriteLine("AGROPECUARIO:");
            var q1 = (from emp in datos8 where emp.Area.Contains("AGROPECUARIO") select emp).ToList();  
            q1.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q1.Count} - {q1.Sum(item => item.Salario)}\n");

            Console.WriteLine("DEPORTE:");
            var q2 = (from emp in datos8 where emp.Area.Contains("DEPORTE") select emp).ToList();  
            q2.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q2.Count} - {q2.Sum(item => item.Salario)}\n");
            
            Console.WriteLine("PROMOCION:");
            var q3 = (from emp in datos8 where emp.Area.Contains("PROMOCION") select emp).ToList();  
            q3.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q3.Count} - {q3.Sum(item => item.Salario)}\n");

            Console.WriteLine("JUBILADOS:");
            var q4 = (from emp in datos8 where emp.Area.Contains("JUBILADOS") select emp).ToList();  
            q4.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q4.Count} - {q4.Sum(item => item.Salario)}\n");

            Console.WriteLine("CULTURA:");
            var q5 = (from emp in datos8 where emp.Area.Contains("CULTURA") select emp).ToList();  
            q5.ForEach(r=>Console.WriteLine(r.ToString()));
            Console.WriteLine($"Total: {q5.Count} - {q5.Sum(item => item.Salario)}\n");

            Console.WriteLine($"Total Areas: 5- {datos8.Sum(item => item.Salario)}\n");

            }
                

        }

                // Recibe un nombre de archivo y regresa una lista de registros de la clase Empleado
        public static List<Empleado> Leer(string file) {
            using (var  reader = new StreamReader(file))
            using (var cvs = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                cvs.Configuration.HasHeaderRecord=false;
                cvs.Read();
                var records=cvs.GetRecords<Empleado>().ToList();
                return records;
            }
        }


        public static void Grabar(List<Empleado> records, string file) {
             using (var writer = new StreamWriter(file))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }           
        }
    }
}
