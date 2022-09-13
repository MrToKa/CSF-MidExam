using System;

namespace TheHuntingGames
{
    class TheHuntingGames
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());

            bool enoughEnergy = true;
            double totalWater = daysOfAdventure * players * waterPerDay;
            double totalFood = daysOfAdventure * players * foodPerDay;

            for (int i = 1; i <= daysOfAdventure; i++)
            {
                energy -= double.Parse(Console.ReadLine());

                if (energy <= 0)
                {
                    enoughEnergy = false;
                    break;
                }

                if (i % 2 == 0)
                {
                    energy *= 1.05;
                    totalWater *= 0.7;
                }
                if (i % 3 == 0)
                {
                    energy *= 1.1;
                    totalFood -= totalFood / players;
                }

            }

            if (enoughEnergy)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
            }
        }
    }
}
