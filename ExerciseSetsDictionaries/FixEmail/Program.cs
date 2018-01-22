using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FixEmail
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();
                var emailToken = email.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                var extension = emailToken[1];
                if (extension == "uk" || extension == "us")
                {
                    continue;
                }

                users.Add(name, email);
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} -> {user.Value}");
            }
        }
    }
}
