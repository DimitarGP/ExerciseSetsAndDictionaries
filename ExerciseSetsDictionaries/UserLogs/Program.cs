using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    public class Program
    {
        public static void Main()
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var messageToken = line.Split(' ');
                var ip = messageToken[0].Replace("IP=", "");
                var username = messageToken[2].Replace("user=","");

                if (users.ContainsKey(username))
                {
                    if (users[username].ContainsKey(ip))
                    {
                        users[username][ip] += 1;
                    }
                    else
                    {
                        users[username][ip] = 1;
                    }
                }
                else
                {
                    users[username] = new Dictionary<string, int>(){{ip,1}};
                }

                line = Console.ReadLine();
            }
            PrintResult(users);
        }

        private static void PrintResult(SortedDictionary<string, Dictionary<string, int>> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}:");
                Console.WriteLine("{0}",
                    String.Join(", ",user.Value.Select(a => $"{a.Key} => {a.Value}")));
            }
        }
    }
}
