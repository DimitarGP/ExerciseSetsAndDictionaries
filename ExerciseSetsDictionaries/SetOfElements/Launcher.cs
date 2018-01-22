using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOfElements
{
    public class Launcher
    {
        public static void Main()
        {
            var line = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = line[0];
            int m = line[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n+m; i++)
            {
                int acceptNumber = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    firstSet.Add(acceptNumber);
                }
                else
                {
                    secondSet.Add(acceptNumber);
                }
            }

            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
