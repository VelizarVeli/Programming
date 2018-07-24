using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _03.TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;

            while ((input = Console.ReadLine()) != "Play!")
            {
                string[] inp = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = inp[0];

                switch (command)
                {
                    case "Install":
                        InstallGame(inp, games);
                        break;
                    case "Uninstall":
                        UninstallGame(inp, games);
                        break;
                    case "Update":
                        Update(inp, games);
                        break;
                    case "Expansion":
                        AddExpansion(inp, games);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", games));
        }

        private static void AddExpansion(string[] inp, List<string> games)
        {
            string game = inp[1].Split('-')[0];
            string expansion = inp[1].Split('-')[1];

            var currentGame = games.FirstOrDefault(a => a == game);

            if (currentGame != null)
            {
                int indexOf = games.IndexOf(game) + 1;
                games.Insert(indexOf, game + ":" + expansion);
            }
        }

        private static void Update(string[] inp, List<string> games)
        {
            string game = inp[1];

            var currentGame = games.FirstOrDefault(a => a == game);

            if (currentGame != null)
            {
                games.Remove(currentGame);
                games.Add(game);
            }
        }

        private static void UninstallGame(string[] inp, List<string> games)
        {
            string game = inp[1];

            var currentGame = games.FirstOrDefault(a => a == game);

            if (currentGame != null)
            {
                games.Remove(currentGame);
            }
        }

        private static void InstallGame(string[] inp, List<string> games)
        {
            string game = inp[1];

            var currentGame = games.FirstOrDefault(a => a == game);

            if (currentGame == null)
            {
                games.Add(game);
            }
        }
    }
}
