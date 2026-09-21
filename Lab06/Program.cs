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

            // Lab06 Assignment below here

            Console.WriteLine("========== Dungeon of Happiness and Fullfillness ==========");

            // Player configuration
            var humanRace = "Human";
            var elfRace = "Elf";
            var angelRace = "Angel";

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
            float heroHpLeft = heroHealth;
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
            }
            else
            {
                heroMaxHP += 60f;
                heroHealth += 60f;
                heroAttack += 10f;
                heroMagic += 30f;
            }

            // Ensure current health never exceeds the maximum HP

            if (heroHealth > heroMaxHP)
            {
                heroHealth = heroMaxHP;
            }

            // Input and check for Player name naja

            var heroName = GetHeroName();
            static string GetHeroName()
            {
                Console.Write("Please Enter your hero name : ");
                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input) || !input.All(char.IsLetter))
                {
                    Console.WriteLine("Invalid name. Must contain letters only, nor cannot be empty space.");
                    return GetHeroName();
                }
                return input;
            }

            // Story Introduction

            Console.WriteLine("===========================================================");
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
            Console.WriteLine($"MAG : {heroMagic}");
            Console.WriteLine("===========================================================");

            Console.WriteLine("As you step into the dungeon, you feel a sense of adventure and danger...");
            Console.WriteLine("Then, suddenly! A Prison guard who has already been an undead has stop you from getting further!");
            Console.WriteLine("Input anything to continue...");
            Console.ReadLine();
            Console.WriteLine("===== Encounter =====");
            Console.WriteLine("You have encountered a Prison Guard!");

            // Monster configuration

            var enemyLevel = rng.Next(1, 11);
            int enemyMaxHP = 50 + (enemyLevel * 2);
            int enemyHealth = 50 + (enemyLevel * 2);
            int enemyAttack = 5 + (enemyLevel * 2);
            int enemyDefense = 3 + (enemyLevel * 2);
            int enemySpeed = 1 + (enemyLevel);
            float enemyHpLeft = enemyHealth;
            Console.WriteLine("===== Enemy Stats =====");
            Console.WriteLine("Prison Guard");
            Console.WriteLine($"Prsion Guard LV : {enemyLevel}");
            Console.WriteLine($"Prison Guard HP : {enemyMaxHP} / {enemyMaxHP}");
            Console.WriteLine($"Prison Guard ATK : {enemyAttack}");
            Console.WriteLine($"Prison Guard DF : {enemyDefense}");
            Console.WriteLine("========================");
            Console.WriteLine();

            // Fight Begin

            Console.WriteLine("===== Turn 1 =====");
            Console.WriteLine("Player Turn");
            Console.WriteLine("Choose your action");
            Console.WriteLine("1. Basic Attack");
            Console.WriteLine("2. Heavy Attack");
            Console.Write("You have choosen : ");
            bool isPlayerChoiceValid = int.TryParse( Console.ReadLine(), out int playerChoice);
            if (isPlayerChoiceValid == false)
            {
                Console.WriteLine("Invalid input please enter 1 or 2");
            }

            if (playerChoice == 1)
            {
                float playerBasicAttack = Math.Max(0, heroAttack - enemyDefense);
                enemyHpLeft = Math.Max(0, enemyHealth - playerBasicAttack);
                Console.WriteLine($"Player use Basic Attack! deal {playerBasicAttack} Damage!");
                Console.WriteLine($"the Prison Guard now have {enemyHpLeft} HP left!");
            }

            else
            {
                float playerHeavyAttack = Math.Max(0, (heroAttack * 2) - enemyDefense);
                enemyHpLeft = Math.Max(0, enemyHealth - playerHeavyAttack);
                Console.WriteLine($"Player use Heavy Attack! deal {playerHeavyAttack} Damage");
                Console.WriteLine($"the Prison Guard now have {enemyHpLeft} HP left!");
            }
            if (enemyHpLeft <= 0)
            {
                Console.WriteLine("The Enemy is dead!");
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("The Prison Guard is still blocking your way");
            }
        }
    }
}