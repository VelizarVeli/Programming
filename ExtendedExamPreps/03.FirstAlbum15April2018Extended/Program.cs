using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.FirstAlbum15April2018Extended
{
    class Program
    {
        static void Main()
        {
            string input;
            int counter = 0;
            List<Song> songs = new List<Song>();
            while ((input = Console.ReadLine()) != "Rock on!")
            {
                string songName = string.Empty;
                string lyrics = string.Empty;
                string length = string.Empty;
                songName = FindName(input);
                lyrics = FindLyrics(input);
                length = FindLength(input); 

                if (songName != string.Empty && lyrics != string.Empty && length != string.Empty)
                {
                    songs.Add(new Song(songName, lyrics, length));
                    counter++;
                    if (counter == 4)
                    {
                        break;
                    }
                }
            }

            foreach (var song in songs)
            {
                Console.WriteLine($"{song.Name} -> {song.Length} => {song.Lyrics}");
            }
        }

        private static string FindLength(string input)
        {
            string pattern = @"(\d+)s";

            string inSeconds = string.Empty;
            foreach (Match m in Regex.Matches(input, pattern))
            {
                inSeconds = m.Groups[1].Value;
                if (inSeconds != string.Empty)
                {
                    int secondsTotal = int.Parse(inSeconds);
                    int seconds = secondsTotal % 60;
                    int minutes = secondsTotal / 60;

                    inSeconds = $"{minutes:D2}:{seconds:D2}";
                }
            }

            if (inSeconds == string.Empty)
            {
                pattern = @"(\d{2}:\d{2})m";
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    inSeconds = m.Groups[1].Value;
                }
            }
            return inSeconds;
        }

        private static string FindLyrics(string input)
        {
            string pattern = @"""([A-Za-z ]{3,})""";

            string lyrics = string.Empty;
            foreach (Match m in Regex.Matches(input, pattern))
            {
                lyrics = m.Groups[1].Value;
            }

            return lyrics;
        }

        private static string FindName(string input)
        {
            string pattern = @"\[(?[^-\s][a-zA-Z\s\-]+[^-\s])\]";

            string name = string.Empty;
            foreach (Match m in Regex.Matches(input, pattern))
            {
                name = m.Groups[1].Value;
            }

            return name;
        }

        public class Song
        {
            public string Name { get; set; }
            public string Lyrics { get; set; }
            public string Length { get; set; }

            public Song(string name, string lyrics, string length)
            {
                this.Name = name;
                this.Lyrics = lyrics;
                this.Length = length;
            }
        }
    }
}
