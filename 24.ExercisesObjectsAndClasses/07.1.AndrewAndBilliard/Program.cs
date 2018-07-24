using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._1.AndrewAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new []{'-'});
                if (!shop.ContainsKey(input[0]))
                {
                    shop.Add(input[0], decimal.Parse(input[1]));
                }
                else
                {
                    shop[input[0]] = decimal.Parse(input[1]);
                }
            }
            string input2 = Console.ReadLine();
            List<Customer> students = new List<Customer>();
            while (input2 != "end of clients")
            {
                string[] inputi = input2.Split(new[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputi[0];
                string product = inputi[1];
                int quantity = int.Parse(inputi[2]);

                if (shop.ContainsKey(product))
                {
                    if (!students.Any(x => x.Name == name))
                    {
                        Customer customer = new Customer();
                        customer.Name = name;
                        customer.ShopList = new Dictionary<string, int>();
                        customer.ShopList.Add(product, quantity);
                        customer.Bill = shop[product] * quantity;
                        students.Add(customer);
                    }
                    else
                    {
                        var currentCustomer = students.First(x => x.Name == name);
                        currentCustomer.Bill += shop[product] * quantity;

                        if (!currentCustomer.ShopList.ContainsKey(product))
                        {
                            currentCustomer.ShopList.Add(product, quantity);
                        }
                        else
                        {
                            currentCustomer.ShopList[product] += quantity;
                        }
                    }
                }
                input2 = Console.ReadLine();
            }
            foreach (Customer customer in students.OrderBy(a=>a.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var stud in customer.ShopList)
                {
                    Console.WriteLine($"-- {stud.Key} - {stud.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            Console.WriteLine($"Total bill: {students.Sum(x=>x.Bill):f2}");
        }

    }
    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }
}
