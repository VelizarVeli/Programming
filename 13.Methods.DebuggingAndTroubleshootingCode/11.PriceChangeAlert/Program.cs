using System;

class PriceChangeAlert
{
    static bool FindDifference(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    static string Get(double c, double last, double difference, bool eitherTrueOrFalse)
    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", c);
        }
        else if (!eitherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, difference * 100);
        }
        else if (eitherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, difference * 100);
        }
        else if (eitherTrueOrFalse && (difference < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, difference * 100);
        return to;
    }

    static double Proc(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }

    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double c = double.Parse(Console.ReadLine());
            double div = Proc(last, c);
            bool isSignificantDifference = FindDifference(div, significanceThreshold);
            string message = Get(c, last, div, isSignificantDifference);
            Console.WriteLine(message);
            last = c;
        }
    }
    
}
