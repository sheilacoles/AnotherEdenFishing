using Sheila.AnotherEdenFishing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheila.AnotherEdenFishing
{
    class Program
    {
        private static IAnotherEdenRepository AnotherEdenRepository = new AnotherEdenRepository();

        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add fish name." +
                "\nPress 2 to add fish pond name." +
                "\nPress 3 to add player name." +
                "\nPress 4 to add fish bait name." +
                "\nPress 5 to add fish bait quality name." +
                "\nPress 6 to get all fish.");
            while (true)
            {
                Console.Write("Enter command number: ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Add<Fish>("Please enter fish name: ");
                        break;
                    case 2:
                        Add<Pond>("Please enter pond name: ");
                        break;
                    case 3:
                        Add<Player>("Please enter player name: ");
                        break;
                    case 4:
                        Add<FishBait>("Please enter fishbait name: ");
                        break;
                    case 5:
                        Add<FishBaitQuality>("Please enter fish bait quality name: ");
                        break;
                    case 6:
                        GetFish();
                        break;
                    default:
                        Console.WriteLine("Please enter command in range 1-6");
                        break;
                }
            }
        }

        private static void Add<T>(string message) where T : BaseModel, new()
        {
            Console.Write(message);
            string name = Console.ReadLine();
            var entity = new T
            {
                Name = name
            };
            AnotherEdenRepository.Add(entity);
        }
        private static void GetFish()
        {
            var fishes = AnotherEdenRepository.GetAll();
            foreach (var fish in fishes)
            {
                Console.WriteLine(fish.Name);
            }
            Console.ReadKey();
        }
    }
}
