using System;
using System.Collections.Generic;

namespace MinerTask
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string,int> resources = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                int quontity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, quontity);
                }
                else
                {
                    resources[resource] += quontity;
                }
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
