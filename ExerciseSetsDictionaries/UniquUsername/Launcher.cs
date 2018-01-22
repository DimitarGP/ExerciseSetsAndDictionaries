using System;
using System.Collections.Generic;

namespace UniquUsername
{
    public class Launcher
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < num; i++)
            {
                string user = Console.ReadLine();
                if (user != null) usernames.Add(user);
            }

            foreach (var user in usernames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
