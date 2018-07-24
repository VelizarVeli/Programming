using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TravelCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> companyData = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> group = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "ready")
            {
                string city = input[0];
                if (!companyData.ContainsKey(city))
                {
                    companyData.Add(city, new Dictionary<string, int>());
                }
                string[] vehiclesCapacity = input[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var vehicle in vehiclesCapacity)
                {
                    string[] vehCap = vehicle.Split('-');
                    string veh = vehCap[0];
                    int cap = int.Parse(vehCap[1]);
                    if (!companyData[city].ContainsKey(veh))
                    {
                        companyData[city].Add(veh, cap);
                    }
                    companyData[city][veh] = cap;
                }

                input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var cityCap in companyData)
            {
                string city = cityCap.Key;
                Dictionary<string, int> vehCap = cityCap.Value;
                if (!group.ContainsKey(city))
                {
                    group.Add(city, 0);
                }
                foreach (var veh in vehCap)
                {
                    string vehic = veh.Key;
                    int capa = veh.Value;
                    group[city] += capa;
                }
            }
            string secondInput = Console.ReadLine();
            while (secondInput != "travel time!")
            {
                string[] cityGroup = secondInput.Split();
                string city = cityGroup[0];
                int groupa = int.Parse(cityGroup[1]);
                foreach (var cityGroupe in group)
                {
                    string cityInGroup = cityGroupe.Key;
                    int groupCapacity = cityGroupe.Value;
                    if (city == cityInGroup)
                    {
                        if (groupa > groupCapacity)
                        {
                            Console.WriteLine($"{cityInGroup} -> all except {groupa - groupCapacity} accommodated");
                        }
                        else
                        {
                            Console.WriteLine($"{cityInGroup} -> all {groupa} accommodated");
                        }
                    }
                }
                secondInput = Console.ReadLine();
            }
        }
    }
}
