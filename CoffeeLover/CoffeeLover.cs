using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeLover
{
    class CoffeeLover
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Include")
                {
                    coffeeList.Add(command[1]);
                }
                if (command[0] == "Remove")
                {
                    string removePlace = command[1];
                    int removeCount = int.Parse(command[2]);

                    if (removeCount > coffeeList.Count)
                    {
                        continue;
                    }
                    if (removePlace == "first")
                    {
                        coffeeList.RemoveRange(0, removeCount);
                    }
                    if (removePlace == "last")
                    {
                        coffeeList.RemoveRange(coffeeList.Count - removeCount, removeCount);
                    }
                }
                if (command[0] == "Prefer")
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);

                    if (coffeeList.Count - 1 >= firstIndex && coffeeList.Count >= secondIndex)
                    {
                        string firstCoffee = coffeeList[firstIndex];
                        string secondCoffee = coffeeList[secondIndex];
                        coffeeList.RemoveAt(firstIndex);
                        coffeeList.Insert(firstIndex, secondCoffee);
                        coffeeList.RemoveAt(secondIndex);
                        coffeeList.Insert(secondIndex, firstCoffee);
                    }
                }
                if (command[0] == "Reverse")
                {
                    coffeeList.Reverse();
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffeeList));
        }
    }
}
