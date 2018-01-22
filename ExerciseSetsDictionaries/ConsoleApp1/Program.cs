using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int .Parse(Console.ReadLine());
            var logs = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < num; i++)
            {
                var line = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string userName = line[1];
                string ip = line[0];
                int duration = int.Parse(line[2]);

                FillLogs(logs, userName, ip, duration);
            }

            PrintLogs(logs);

        }

        private static void FillLogs(SortedDictionary<string, Dictionary<string, int>> logs, 
            string userName, string ip, int duration)
        {
            if (!logs.ContainsKey(userName))
            {
                logs[userName] = new Dictionary<string, int>();
            }

            if (!logs[userName].ContainsKey(ip))
            {
                logs[userName].Add(ip, 0);
                logs[userName][ip] += duration;
            }
            else
            {
                logs[userName][ip] += duration;
            }
        }

        private static void PrintLogs(SortedDictionary<string, Dictionary<string, int>> logs)
        {
            foreach (var log in logs)
            {
                Console.WriteLine("{0}: {1} [{2}] ", log.Key, log.Value.Values.Sum(),
                    string.Join(", ",log.Value.Select(x => x.Key)));
            }
        }
    }
}
