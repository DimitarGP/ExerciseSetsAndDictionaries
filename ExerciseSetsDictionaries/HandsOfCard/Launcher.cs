using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HandsOfCard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<String, HashSet<string>> players = new Dictionary<string, HashSet<string>>();
            string handout = Console.ReadLine();
            while (handout != "JOKER")
            {
                var handToken = handout.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = handToken[0];

                var cards = handToken[1]
                    .Split(',')
                    .Select(a => a.Trim())
                    .ToArray();

                if (players.ContainsKey(name))
                {
                    players[name].UnionWith(cards);
                }

                else
                {
                    players[name] = new HashSet<string>(cards);
                }

                handout = Console.ReadLine();
            }

            PrintPlayersAndScore(players);
        }

        private static void PrintPlayersAndScore(Dictionary<string, HashSet<string>> players)
        {
            foreach (var player in players)
            {
                var score = CalculateScore(player.Value);
                Console.WriteLine($"{player.Key}: {score}");
            }
        }

        private static int CalculateScore(HashSet<string> cards)
        {
            int totalScore = 0;
            foreach (var card in cards)
            {
                var type = card.Last();
                var power = card.Substring(0, card.Length - 1);

                int score;
                var isDigit = int.TryParse(power, out score);
                if (!isDigit)
                {
                    switch (power)
                    {
                        case "J":
                            score = 11;
                            break;
                        case "Q":
                            score = 12;
                            break;
                        case "K":
                            score = 13;
                            break;
                        case "A":
                            score = 14;
                            break;
                    }
                }

                switch (type)
                {
                    case 'S':
                        score *= 4;
                        break;
                    case 'H':
                        score *= 3;
                        break;
                    case 'D':
                        score *= 2;
                        break;
                    case 'C':
                        score *= 1;
                        break;
                }

                totalScore += score;
            }

            return totalScore;
        }
    }
}
