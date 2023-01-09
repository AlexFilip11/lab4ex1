using System;

namespace lab4ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul
           
            Console.WriteLine("introduceti nr de elemente din vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine("Introduceti elementele din vector: ");
            vector = ReadVector(n);
            Console.WriteLine("Vectorul inversat este: ");
            ShowVector(ReverseVector(vector));
        }
        static int[] ReadVector(int n)
        {
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }
            return vector;
        }
        static int[] ReverseVector(int[] vector)
        {
            int aux, j = vector.Length-1;
            for(int i=0; i<vector.Length/2; i++)
            {
                aux = vector[i];
                vector[i] = vector[j];
                vector[j] = aux;
                j--;
            }
            return vector;
        }
        static void ShowVector(int[] vector)
        {
            for(int i=0; i<vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }
        static int[,] ReadMatrix(int n, m, k)
        {

        }

    }
}
