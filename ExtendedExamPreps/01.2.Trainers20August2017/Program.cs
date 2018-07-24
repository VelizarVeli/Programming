using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//решена за 36 минути 100/100
namespace _01._2.Trainers20August2017
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            decimal Technical = 0;
            decimal Theoretical = 0;
            decimal Practical = 0;
            for (int i = 0; i < N; i++)
            {
                long distanceToTravelInMiles = long.Parse(Console.ReadLine());
                decimal cargoInTons = decimal.Parse(Console.ReadLine());
                string teamParticipant = Console.ReadLine();
                decimal cargoInKg = cargoInTons * 1000;
                long distanceInMeters = distanceToTravelInMiles * 1600;
                decimal participantEarnedMoney = (cargoInKg * 1.5M) - (0.7M * distanceInMeters * 2.5M);
                if (teamParticipant == "Technical")
                {
                    Technical += participantEarnedMoney;
                }
                else if (teamParticipant == "Theoretical")
                {
                    Theoretical += participantEarnedMoney;
                }
                else if (teamParticipant == "Practical")
                {
                    Practical += participantEarnedMoney;
                }
            }
            decimal winner1 = Math.Max(Technical, Theoretical);
            decimal winner = Math.Max(winner1, Practical);

            if (winner == Technical)
            {
                Console.WriteLine($"The Technical Trainers win with ${winner:f3}.");
            }
            else if (winner == Theoretical)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${winner:f3}.");
            }
            else if (winner == Practical)
            {
                Console.WriteLine($"The Practical Trainers win with ${winner:f3}.");
            }
        }
    }
}
