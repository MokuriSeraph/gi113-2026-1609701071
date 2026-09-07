/*
 * Student ID : 1690701071
 * Name       : Peraphat Sungwan
 * Section    : 129A
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable setting
            const int MaxLevel = 20;

            var bossName = "Mokuri";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 20;
            int maxHp = 999;
            int currentHp = 520;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 99.999f;
            double critMultiplier = 2.55;
            bool isBoss = true;

            Console.WriteLine("===== MOKURI SAVE CONVERTER =====");
            Console.WriteLine($"Name : {bossName}");
            Console.WriteLine($"Rank : {rank}");
            Console.WriteLine($"Level : {level} / {MaxLevel}");
            Console.WriteLine($"HP : {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power : {attackPower}");
            Console.WriteLine($"Critical Multiplier : {critMultiplier}");
            Console.WriteLine($"Is Boss : {isBoss}");

            // Implicit conversion Int to Double

            double currentHpDouble = currentHp; // Implicit conversion from int to double
            Console.WriteLine($"HP (Double) : {currentHpDouble}");
            Console.WriteLine();

            // HP Percent no inter truncation

            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            
            double hpPercent = (currentHpDouble * 100 / maxHp); // int / int then converted to double to stored the decimal
            Console.WriteLine($"HP Percent : {hpPercent}%");
            Console.WriteLine();

            // Explicit by casting (float) AttackPower to int

            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            int attackInt = (int)attackPower; // convertion by Cast Syntax: (ชนิดที่ต้องการแปลง)ชื่อที่ต้องการแปลง
            Console.WriteLine($"AttackPower (int cast): {attackInt}");
            Console.WriteLine();

            // Cast vs Convert : Crit Multiplier

            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier; // Convert critMultiplier to int by casting
            int critConvert = Convert.ToInt32(critMultiplier); // Convert critMultiplier from double to int by conversion
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert Rounded): {critConvert}");
        }
    }
}
