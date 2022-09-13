using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneShop
{
    class PhoneShop
    {
        static void Main(string[] args)
        {
            List<string> phonesList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] command = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Add")
                {
                    if (!phonesList.Contains(command[1]))
                    {
                        phonesList.Add(command[1]);
                    }
                }
                if (command[0] == "Remove")
                {
                    if (phonesList.Contains(command[1]))
                    {
                        phonesList.Remove(command[1]);
                    }
                }
                if (command[0] == "Bonus phone")
                {
                    string bonusPhone = command[1];
                    string[] phones = bonusPhone
                        .Split(":", StringSplitOptions.RemoveEmptyEntries);

                    if (phonesList.Contains(phones[0]))
                    {
                        int oldPhoneIndex = phonesList.IndexOf(phones[0]);
                        phonesList.Insert(oldPhoneIndex + 1, phones[1]);
                    }
                }
                if (command[0] == "Last")
                {
                    if (phonesList.Contains(command[1]))
                    {
                        string tempPhone = command[1];
                        phonesList.Remove(command[1]);
                        phonesList.Add(tempPhone);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", phonesList));
        }
    }
}
