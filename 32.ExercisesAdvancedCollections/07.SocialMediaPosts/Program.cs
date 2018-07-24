using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SocialMediaPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            while (input != "drop the media")
            {
                List<string> inputArr = input.Split().ToList();
                string command = inputArr[0];
                string what = inputArr[1];
                if (command == "post")
                {
                    if (!data.ContainsKey(command))
                    {
                        data.Add(what, new Dictionary<string, int>());
                        data[what].Add("likes", 0);
                        data[what].Add("dislikes", 0);
                    }
                }
                if (command == "like")
                {
                    data[what]["likes"]++;
                }
                else if (command == "dislike")
                {
                    data[what]["dislikes"]++;
                }
                else if (command == "comment")
                {
                    inputArr.RemoveRange(0, 2);
                    string nameOfTheCommentator = inputArr[0];
                    inputArr.RemoveAt(0);
                    string coms = nameOfTheCommentator + ": " + string.Join(" ", inputArr);
                    data[what].Add(coms, 0);
                }

                input = Console.ReadLine();
            }
            foreach (KeyValuePair<string, Dictionary<string, int>> post in data)
            {
                string postName = post.Key;
                Dictionary<string, int> likDisComm = post.Value;
                Console.Write($"Post: {postName} |");
                foreach (var item in likDisComm)
                {
                    string likDiskom = item.Key;
                    int num = item.Value;
                    if (likDiskom == "likes")
                    {
                        Console.Write($" Likes: {num} |");
                    }
                    else if (likDiskom == "dislikes")
                    {
                        Console.Write($" Dislikes: {num}\nComments:\n");
                        if (likDisComm.Keys.Count < 3)
                        {
                            Console.WriteLine("None");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"*  {likDiskom}");
                    }
                }
            }
        }
    }
}
