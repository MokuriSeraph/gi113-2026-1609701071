/*
 * Student ID : 1690701071
 * Name       : Peraphat Sungwan
 * Section    : 129A
 * No.        : 37
 * Course     : GI113 Computer Programming (GI)
 */

using System.Runtime.CompilerServices;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int lives = 5;
            if (lives == 0) // ในวงเว็บ = Boolean
            {
                Console.WriteLine("Game Over");
            }

            Console.WriteLine("GameStillRunning");

            // Part 2

            int coins = 100;
            int shortSwordPrice = 250;

            if (coins >= shortSwordPrice)
            {
                Console.WriteLine("You have purchased the short sword.");
            }
            else
            {
                Console.WriteLine("You cannot buy this item!");
            }

            // Part 3 Else If

            int score = 67;

            if (score >= 90)
            {
                Console.WriteLine("You got A+ grade!");
            }

            else if (score == 67)
            {
                Console.WriteLine("SIX SEVEENNNNNNNNNNN");
            }

            else if (score >= 60)
            {
                Console.WriteLine("You got B grade!");
                Console.WriteLine("There's still room to improve");
            }
            else
            {
                Console.WriteLine("You got C grade!");
                Console.WriteLine("Better Luck next time!");
            }

            // Part 4 Input

            Console.WriteLine("Your Level (1-99): ");
            bool isLevelValid = int .TryParse(Console.ReadLine(), out int level);

            if (!isLevelValid || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid Level I sa. Please enter again");
            }
            else if (level >= 10)
            {
                Console.WriteLine("Wow! You are a high-level player!");
                Console.WriteLine("The Boss Floor has opened...");
            }
            else if (level >= 5)
            {
                Console.WriteLine("Nothing Special about you.");
                Console.WriteLine("The New Floor has opened...");
            }
            else
            {
                Console.WriteLine("Your level is too low. Go KYS. NOW!");
            }*/

            Console.WriteLine("========== Dungeon of Happiness and Fullfillness ==========");

            // Player configuration
            var humanRace = "Human";
            var elfRace = "Elf";
            var angelRace = "Angel";
            bool isPlayableHero = true;
            // Use one Random instance and a weighted roll for race probabilities
            var rng = new Random();
            double roll = rng.NextDouble(); // 0.0 - 1.0
            int raceRandom;
            if (roll < 0.5) // 50% chance
                raceRandom = 1; // Human
            else if (roll < 0.8) // next 30% (0.5 - 0.8)
                raceRandom = 2; // Elf
            else // remaining 20% (0.8 - 1.0)
                raceRandom = 3; // Angel

            int heroLevel = rng.Next(1, 21);
            float heroMaxHP = 100.0f + (heroLevel);
            float heroHealth = 100.0f + (heroLevel);
            float heroAttack = 10.0f + (heroLevel * 2);
            float heroMagic = 10.0f;
            float heroDefense = 5.0f + (heroLevel * 1.5f);
            float heroSpeed = 5.0f;
            var race = new Dictionary<int, string>() // race randomizer
            {
                { 1, humanRace },
                { 2, elfRace },
                { 3, angelRace }
            };

            if (race[raceRandom] == humanRace)
            {
                heroHealth += 20f;
                heroMaxHP += 20f;
            }
            else if (race[raceRandom] == elfRace)
            {
                heroMaxHP -= 20f;
                heroMagic += 10f;
                heroDefense += 5f;
                heroSpeed += 5f;
            }
            else
            {
                heroMaxHP += 60f;
                heroHealth += 60f;
                heroAttack += 10f;
                heroMagic += 30f;
                heroSpeed += 7f;
            }

            // Ensure current health never exceeds the maximum HP
            if (heroHealth > heroMaxHP)
            {
                heroHealth = heroMaxHP;
            }

            Console.Write("Please enter your Hero name : ");
            string heroName = Console.ReadLine();

            Console.WriteLine($"Welcome to the Dungeon of Happiness and Fullfillness. The rumours were told that whoever has reached the deepest floor of this dungeon they will recieve 3 wishses.");
            Console.WriteLine($"So you are here to find out...");
            Console.WriteLine($"You are {heroName}.");
            Console.WriteLine();
            Console.WriteLine($"===== Player Stats =====");
            Console.WriteLine($"Name: {heroName}");
            Console.WriteLine($"Level: {heroLevel}");
            Console.WriteLine($"Race: {race[raceRandom]}");
            Console.WriteLine($"HP: {heroHealth}/{heroMaxHP}");
            Console.WriteLine($"ATK : {heroAttack}");
            Console.WriteLine($"DEF : {heroDefense}");
        }
    }
}