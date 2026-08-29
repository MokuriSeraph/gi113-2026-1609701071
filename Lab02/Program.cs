 /*
 * Student ID : 1690701071
 * Name       : Peraphat Sungwan
 * Section    : 129A
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */


namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 240;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");

            int hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercentage}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 dmg!");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP : {currentHp} / {maxHp}");
            Console.WriteLine($"{hpPercentage}%");

            // Lab 2 //
            // RPG Genre Type

            // playable characters

            string playerName1 = "Mokuri";
            string playerRace1 = "Seraphim";
            char grade = 'S';
            int playerLevel1 = 20;
            int playermaxHp1 = 999;
            int playercurrentHp1 = 999;
            int playerspeed1 = 10;
            float playerattackPower1 = 99.9f;
            double playercritMultiplier1 = 3;
            bool isPlayer = false;

            string playerName2 = "Rubite";
            string playerRace2 = "Human Hybrid";
            char grade2 = 'A';
            int playerLevel2 = 20;
            int playermaxHp2 = 300;
            int playercurrentHp2 = 300;
            int playerspeed2 = 8;
            float playerattackPower2 = 69f;
            double playercritMultiplier2 = 2;
            bool isPlayer2 = true;

            string playerName3 = "Hana";
            string playerRace3 = "Human";
            char grade3 = 'B';
            int playerLevel3 = 15;
            int playermaxHp3 = 150;
            int playercurrentHp3 = 150;
            int playerspeed3 = 7;
            float playerattackPower3 = 10f;
            double playercritMultiplier3 = 1.75;
            bool isPlayer3 = true;

            string playerName4 = "Vivec";
            string playerRace4 = "Dragonborn";
            char grade4 = 'S';
            int playerLevel4 = 20;
            int playermaxHp4 = 550;
            int playercurrentHp4 = 550;
            int playerspeed4 = 5;
            float playerattackPower4 = 80f;
            double playercritMultiplier4 = 2;
            bool isPlayer4 = true;

            // Player status print command naja eiei

            Console.WriteLine("===== PLAYER PARTY STATUS: INITIAL =====");
            Console.WriteLine("Party Member 1");
            Console.WriteLine();
            Console.WriteLine($"Name: {playerName1}");
            Console.WriteLine($"Race: {playerRace1}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Level: {playerLevel1}");
            Console.WriteLine($"HP: {playercurrentHp1} / {playermaxHp1}");
            Console.WriteLine($"Speed: {playerspeed1}");
            Console.WriteLine($"Attack Power: {playerattackPower1}");
            Console.WriteLine($"Critical Multiplier: {playercritMultiplier1}");
            Console.WriteLine();

            Console.WriteLine("Party Member 2");
            Console.WriteLine();
            Console.WriteLine($"Name: {playerName2}");
            Console.WriteLine($"Race: {playerRace2}");
            Console.WriteLine($"Grade: {grade2}");
            Console.WriteLine($"Level: {playerLevel2}");
            Console.WriteLine($"HP: {playercurrentHp2} / {playermaxHp2}");
            Console.WriteLine($"Speed: {playerspeed2}");
            Console.WriteLine($"Attack Power: {playerattackPower2}");
            Console.WriteLine($"Critical Multiplier: {playercritMultiplier2}");
            Console.WriteLine();

            Console.WriteLine("Party Member 3");
            Console.WriteLine();
            Console.WriteLine($"Name: {playerName3}");
            Console.WriteLine($"Race: {playerRace3}");
            Console.WriteLine($"Grade: {grade3}");
            Console.WriteLine($"Level: {playerLevel3}");
            Console.WriteLine($"HP: {playercurrentHp3} / {playermaxHp3}");
            Console.WriteLine($"Speed: {playerspeed3}");
            Console.WriteLine($"Attack Power: {playerattackPower3}");
            Console.WriteLine($"Critical Multiplier: {playercritMultiplier3}");
            Console.WriteLine();

            Console.WriteLine("Party Member 4");
            Console.WriteLine();
            Console.WriteLine($"Name: {playerName4}");
            Console.WriteLine($"Race: {playerRace4}");
            Console.WriteLine($"Grade: {grade4}");
            Console.WriteLine($"Level: {playerLevel4}");
            Console.WriteLine($"HP: {playercurrentHp4} / {playermaxHp4}");
            Console.WriteLine($"Speed: {playerspeed4}");
            Console.WriteLine($"Attack Power: {playerattackPower4}");
            Console.WriteLine($"Critical Multiplier: {playercritMultiplier4}");
            Console.WriteLine();
        }
    }
}
