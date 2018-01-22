using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    public class Program
    {
        public static void Main()
        {
            var worldPopulation = new Dictionary<string, Dictionary<string, long>>();
            var line = Console.ReadLine();

            while (line != "report")
            {
                var populationToken = line
                    .Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string town = populationToken[0];
                string country = populationToken[1];
                int townPopulation = int.Parse(populationToken[2]);

                if (!worldPopulation.ContainsKey(country))
                {
                    worldPopulation.Add(country, new Dictionary<string, long>());
                }

                if (!worldPopulation[country].ContainsKey(town))
                {
                    worldPopulation[country].Add(town,townPopulation);
                }

                line = Console.ReadLine();
            }

            foreach (var kvp in worldPopulation.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{kvp.Key} (total population: {kvp.Value.Values.Sum()})");
                foreach (var town in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }
            }

        }
    }
}
