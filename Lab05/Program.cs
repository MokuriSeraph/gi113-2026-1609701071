/*
 * Student ID : 1690701071
 * Name       : Peraphat Sungwan
 * Section    : 129A
 * No.        : 37
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Untitled Fantasy Game ====");
            Console.WriteLine("Testing Combat Calculation");

            // User Input of Stats
            Console.Write("Player HP: ");
            bool isPlayerHpValid = int.TryParse(Console.ReadLine(), out int playerHp);
            Console.Write("Player ATK: ");
            bool isPlayerAtkValid = int.TryParse(Console.ReadLine(), out int playerAtk);
            Console.Write("Player DEF: ");
            bool isPlayerDefValid = int.TryParse(Console.ReadLine(), out int playerDef);

            // Monster Input of Stats
            Console.Write("Monster HP: ");
            bool isMonHpValid = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.Write("Monster ATK: ");
            bool isMonAtkValid = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.Write("Monster DEF: ");
            bool isMonDefValid = int.TryParse(Console.ReadLine(), out int monsterDef);

            // Summary stats
            Console.WriteLine($"[Hero] HP : {playerHp} ATK : {playerAtk} DEF : {playerDef}");
            Console.WriteLine($"[Monster] HP : {monsterHp} ATK : {monsterAtk} DEF : {monsterDef}");

            // Check if the stats are valid
            bool allPlayerStatsValid = isPlayerHpValid && isPlayerAtkValid && isPlayerDefValid;
            bool allMonsterStatsValid = isMonHpValid && isMonAtkValid && isMonDefValid;

            Console.WriteLine($"Stats Validation - Player : {allPlayerStatsValid}");
            Console.WriteLine($"Stats Validation - Monster : {allMonsterStatsValid}");

            // ซนเชยๆครับตรงนี้
            if (allPlayerStatsValid && allMonsterStatsValid)
            { Console.WriteLine("All stats are valid. Starting combat..."); }
            else
            { Console.WriteLine("Invalid stats entered."); }

            // Potion Drink for player
            int potionLessHeal = 10;

            playerHp += potionLessHeal; // is playerHp = playerHp + potionLessHeal
            Console.WriteLine($"Player drank a potion and healed {potionLessHeal} HP.\nCurrent Player HP : {playerHp}");

            // Hero Light Attack (Arithmetic + Math)
            int playerLightAttack = Math.Max(0, playerAtk - monsterDef);
            Console.WriteLine($"Player's light attack deals {playerLightAttack} damage.");

            // Monster Calculate Power ATK (Precedence of multiplication before subtract)
            int monsterLightAttack = Math.Max(0, monsterAtk - monsterDef);
            Console.WriteLine($"Monster's power attack deals {monsterLightAttack} damage.");

            // Critical Chance
            Random rng = new Random();
            int roll = rng.Next(1, 101); // Generates a random number between 1 and 100 (100% max chance)
            bool isCriticalHit = roll <= 10; // 10% chance for critical hit

            // Critical Damage Calculation
            int criDamage = playerLightAttack + Convert.ToInt32(isCriticalHit) * playerLightAttack;

            if (roll <= 10)
            {
                Console.WriteLine($"Critical Hit! Player's attack deals {criDamage} damage.");
            }
            else
            {
                Console.WriteLine($"Did not Cri! remain the same {playerLightAttack} damage.");
            }
        }
    }
}
