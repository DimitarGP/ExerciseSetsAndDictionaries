using System;
using System.Collections.Generic;

namespace CountSymbol
{
    public class Launcher
    {
        public static void Main()
        {
            var line = Console.ReadLine().ToCharArray();
            SortedDictionary<char,int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < line.Length; i++)
            {
                char token = line[i];
                if (!symbols.ContainsKey(line[i]))
                {
                    symbols.Add(token, 1);
                }
                else
                {
                    symbols[token]++;
                }
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }

        }
    }
}
