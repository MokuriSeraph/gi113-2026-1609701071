/*
 * Student ID : 1690701071
 * Name       : Peraphat Sungwan
 * Section    : 129A
 * No.        : 37
 * Course     : GI113 Computer Programming (GI)
 */


namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("|                         New Adventure                      |");
            Console.WriteLine("+------------------------------------------------------------+");

            // Character Creation

            Console.Write("Name Your Hero: ");
            string charName = Console.ReadLine();
            Console.WriteLine("Choose a Character Class:");
            Console.WriteLine("1. Figter");
            Console.WriteLine("2. Healer");
            Console.WriteLine("3. Tanker");

            bool classChoiceValid = int.TryParse(Console.ReadLine(), out int classNum);
            Console.WriteLine("Starting Luck");
            bool luckValid = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"Character Name: {charName}");
            Console.WriteLine($"Class Number : {classNum}");
            Console.WriteLine($"Luck Number : {luck}");


            // Difficulty Set

            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("Choose difficulty ");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Normal");
            Console.WriteLine("3. Hard");
            Console.WriteLine("4. NoPlotArmor");
            Console.WriteLine("+------------------------------------------------------------+");

            bool difficultyValid = int.TryParse(Console.ReadLine(), out int difficultyNum);
            Console.WriteLine($"You have chosen difficulty level {difficultyNum}.");

            // Game Start

            Console.WriteLine();
            Console.WriteLine($"Welcome, {charName}. Your journey begins...");

            // Item Shop

            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("|                         Item Shop                          |");
            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine("which item?");
            Console.WriteLine("1. Dagger");
            Console.WriteLine("2. Healing and Mana Potions");
            Console.WriteLine("3. Katana");
            bool isItemChoiceValid = int.TryParse(Console.ReadLine(), out int itemChoice);
            Console.WriteLine($"You have chosen the {itemChoice}.");
            Console.Write("How many? : ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"You have chosen {quantity}");

            // Set Volume

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool isVolumeValid = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {isVolumeValid}");
            Console.WriteLine($"Volume: {volume}");

            // Save File

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool isSlotValid = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {isSlotValid}");
            Console.WriteLine($"Slot: {slot}");
        }
    }
}
