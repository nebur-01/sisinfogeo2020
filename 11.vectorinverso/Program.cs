using System;

namespace _11.vectorinverso
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=15;

            double[] A = new double[MAX];
            double[] B = new double[MAX];
            

            Random aleatorio = new Random();
         
            //Num aleatorios
            for(int i=0; i<MAX; i++){
                A[i]= aleatorio.Next(1,100);
                B[MAX-1-i]= A[i]; 
            }
              
            imprime(A);
            imprime(B);
        

            Console.WriteLine("Inversa de el vector principal\n");
        }
        static void imprime(double[] v){
            for (int i=0; i<v.Length;i++){
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }
    }
}