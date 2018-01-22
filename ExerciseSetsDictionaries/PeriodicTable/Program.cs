using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 0; i < num; i++)
            {
                var elements = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in elements)
                {
                    chemicalElements.Add(element);
                }
            }

            foreach (var element in chemicalElements)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}
