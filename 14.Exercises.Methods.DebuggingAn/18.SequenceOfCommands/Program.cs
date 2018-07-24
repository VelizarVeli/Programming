using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        sbyte sizeOfArray = sbyte.Parse(Console.ReadLine());

        long[] array = Console.ReadLine().Split(ArgumentsDelimiter).Select(long.Parse).ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string[] line = Console.ReadLine().Split(' ').ToArray();
            int[] args = new int[2];

            if (line[0] == "add" )
                //|| line[0] == "subtract" || line[0] == "multiply")
            {
               
            }

            PerformAction(array, command, args);

            PrintArray(array);
            Console.WriteLine('\n');

            command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[1];
        int value = args[2];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
    }

    private static void ArrayShiftLeft(long[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
