using System;
using System.Collections.Generic;

namespace HashSetSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>() { 1, 2, 3, 4, 5 }; // HashSet é uma coleção que não permite duplicatas e não mantém a ordem dos elementos
            HashSet<int> b = new HashSet<int>() { 4, 5, 6, 7, 8 };

            // Operações de conjunto
            HashSet<int> c = new HashSet<int>(a);
            c.UnionWith(b); // União

            HashSet<int> d = new HashSet<int>(a);
            d.IntersectWith(b); // Interseção

            HashSet<int> e = new HashSet<int>(a);
            e.ExceptWith(b); // Diferença

            Console.WriteLine("União: ");
            PrintCollection(c);

            Console.WriteLine("Interseção: ");
            PrintCollection(d);

            Console.WriteLine("Diferença: ");
            PrintCollection(e);

            SortedSet<int> f = new SortedSet<int>() { 1, -1, 5, -5, 10, -7}; // SortedSet é uma coleção que não permite duplicatas e mantém os elementos ordenados
            PrintCollection(f);
        }

        static void PrintCollection<T>(IEnumerable<T> collection) // IEnumerable<T> faz uma interface genérica que permite iterar sobre uma coleção de elementos de tipo T
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        
    }
}