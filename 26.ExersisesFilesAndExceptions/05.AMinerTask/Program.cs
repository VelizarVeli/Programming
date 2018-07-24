namespace _05_MinerTask
{
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllLines(@"..\..\Input.txt")
                .ToArray();

            int index = 0;
            string resource = input[index++];
            var resources = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(input[index++]);

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += quantity;

                resource = input[index++];
            }
            var resourcesOutput = new List<string>();

            foreach (var rsrc in resources)
            {
                resourcesOutput.Add($"{rsrc.Key} -> {rsrc.Value}");
            }

            File.WriteAllLines(@"..\..\Output.txt", resourcesOutput);
        }
    }
}