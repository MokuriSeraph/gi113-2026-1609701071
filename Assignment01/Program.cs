/*
 * Student ID : 1690701071
 * Name       : Peraphat Sungwan
 * Section    : 129A
 * No.        : 37
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "LobotomyCorporation"; // const, PascalCase


            // Agent Name


            var agentName = "Mokuri";     // var บน string — ต้องให้ compiler เดาชนิด
            char agentRank = 'V';         // var บน char
            int agentId = 2;


            // Agent stats

            int agentFortitude = 120;
            int agentHp = 120;


            int agentPrudence = 120;
            int agentSanity = 120;


            int agentTemperance = 120;
            int agentWorkSpeed = 80;


            int agentJustice = 120;
            float agentWalkSpeed = 67.8f;
            float agentAttackSpeed = 24.7f;
            double agentAttackSpeedPrecise = (double)agentAttackSpeed;  // เลขหลังจุดเป็น 5 ขึ้นไป
            double agentWalkSpeedPrecise = (double)agentWalkSpeed;

            bool isPlayable = true;


            // Agent Weapon ( Ego Suit and Weapon )


            string agentEgoWeapon = "Justitia";
            string agentEgoSuit = "Justitia";


            // Ego Suit resistance stats


            float justitiaRedResistance = 0.5f;
            float justitiaWhiteResistance = 0.5f;
            float justitiaBlackResistance = 0.5f;
            float justitiaPaleResistance = 0.5f;


            // Ego Weapon damage stats


            int justitiaPaleDamage = 24;

            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"\n");
            Console.WriteLine("===== Agent Profile =====");
            Console.WriteLine();
            Console.WriteLine($"Agent Name : {agentName}");
            Console.WriteLine($"Agent Rank : {agentRank}");
            Console.WriteLine($"Agent ID   : {agentId}");
            double agentIdDouble = agentId; // implicit cast
            Console.WriteLine($"AgentID as Double(implicit): {agentIdDouble}");
            Console.WriteLine($"PlayAble : {isPlayable}");
            Console.WriteLine();
            Console.WriteLine($"=========================");
            Console.WriteLine($"\n");

            Console.WriteLine("===== Agent Stats =====");
            Console.WriteLine();
            Console.WriteLine($"Fortitude : {agentFortitude}");
            Console.WriteLine($"HP : {agentHp}");
            Console.WriteLine();

            Console.WriteLine($"Prudence : {agentPrudence}");
            Console.WriteLine($"Sanity : {agentSanity}");
            Console.WriteLine();

            Console.WriteLine($"Temperance : {agentTemperance}");
            Console.WriteLine($"Work Speed : {agentWorkSpeed}");
            Console.WriteLine($"Walk Speed Precise : {agentWalkSpeedPrecise}");
            Console.WriteLine();

            Console.WriteLine($"Justice : {agentJustice}");
            Console.WriteLine($"Walk Speed : {agentWalkSpeed}");
            int agentWalkSpeedTruncated = (int)agentWalkSpeed;               // explicit cast
            int agentWalkSpeedRounded = Convert.ToInt32(agentWalkSpeed);      // Convert
            Console.WriteLine($"Walk Speed Truncated : {agentWalkSpeedTruncated}");
            Console.WriteLine($"Walk Speed Rounded : {agentWalkSpeedRounded}");
            Console.WriteLine();
            Console.WriteLine($"Attack Speed : {agentAttackSpeed}");
            Console.WriteLine($"Attack Speed Precise : {agentAttackSpeedPrecise}");
            Console.WriteLine();
            Console.WriteLine($"=======================");
            Console.WriteLine($"\n");

            Console.WriteLine("===== Agent Weapons and Suit =====");

            // Display Ego Weapon damage stats

            Console.WriteLine();
            Console.WriteLine($"Ego Weapon : {agentEgoWeapon}");
            Console.WriteLine($"Ego Weapon Pale Damage : {justitiaPaleDamage}");
            Console.WriteLine();

            // Display Ego Suit resistance stats

            Console.WriteLine($"Ego Suit : {agentEgoSuit}");
            Console.WriteLine($"Red Resistance : {justitiaRedResistance}");
            Console.WriteLine($"White Resistance : {justitiaWhiteResistance}");
            Console.WriteLine($"Black Resistance : {justitiaBlackResistance}");
            Console.WriteLine($"Pale Resistance : {justitiaPaleResistance}");
            Console.WriteLine();
            Console.WriteLine("================================");
        }
    }
}
