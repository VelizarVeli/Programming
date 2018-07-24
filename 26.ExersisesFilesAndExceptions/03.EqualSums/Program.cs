namespace _03_EqualSums
{
    using System;
    using System.Linq;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {

            var input = File.ReadAllText(@"..\..\Input.txt")
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool equalSumsFound = false;

            for (int i = 0; i < input.Length; i++)
            {
                int[] leftSide = input.Take(i).ToArray();
                int[] rightSide = input.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    File.WriteAllText(@"..\..\Output.txt", i.ToString());
                    equalSumsFound = true;
                    break;
                }
            }

            if (!equalSumsFound)
            {
                File.WriteAllText(@"..\..\Output.txt", "no");
            }
        }
    }
}