namespace _02_IndexOfLetters
{
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllText(@"..\..\Input.txt")
                .ToCharArray();
            var output = new List<string>();

            foreach (var letter in input)
            {
                output.Add($"{letter} -> {letter - 'a'}");
            }

            File.WriteAllLines(@"..\..\Output.txt", output);
        }
    }
}