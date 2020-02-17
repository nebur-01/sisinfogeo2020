using System;

namespace _12.vectormultiplica
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Max = 10;

            double [] A = new double[Max];
            double [] B = new double[Max];
            double [] C = new double[Max];

            Random Aleatorio = new Random();

            for(int i=0; i<Max; i++){
                
                A[i]= Aleatorio.Next(1, 100);
                B[i]= Aleatorio.Next(1, 100);

            }

            Console.Write("\nVectores\n");

            for(int i=0; i<Max; i++){
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine("");

            for(int i=0; i<Max; i++){
                Console.Write($"{B[i]} ");
            }
            Console.WriteLine("\n");

            imprimir(A, B, C);
            
        }

        static void imprimir(double [] v1, double [] v2, double [] v3){

            int j=0, k=9;
            for(int i=0; i<9; i++){
                
                v3[i] = v1[j]*v2[k];
                j++;
                k--;
            }

            for(int i=0; i<9; i++) 
                Console.Write($"{v3[i]} ");
        }
    }
}
