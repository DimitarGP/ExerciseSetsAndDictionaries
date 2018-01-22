using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class Launcher
    {
        public static void Main()
        {
            var phoneBook = new Dictionary<string, string>();

            while (true)
            {
                var line = Console.ReadLine()
                    .Split(new char[] { '-' }
                        , StringSplitOptions
                            .RemoveEmptyEntries);

                if (line[0] == "search")
                {
                    break;
                }

                if (line[0] != null && line[1] != null)
                {
                    if (phoneBook.ContainsKey(line[0]))
                    {
                        phoneBook[line[0]] = line[1];
                    }

                    else
                    {
                        phoneBook.Add(line[0], line[1]);
                    }
                }
            }

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }

                if (phoneBook.ContainsKey(name))
                {
                    string value = phoneBook[name];
                    Console.WriteLine($"{name} -> {value}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
            }
        }
    }
}
