namespace ConsoleApp1
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
            Console.WriteLine("seed settings");
            bool seedValid = double.TryParse(Console.ReadLine(), out double seed);
            Console.WriteLine($"Character Name: {charName}");
            Console.WriteLine($"Class Number : {classNum}");
            Console.WriteLine($"Seed Number : {seed}");


            // Difficulty Set

            string playerName = Console.ReadLine();
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
            Console.WriteLine($"Welcome, {playerName}. Your journey begins...");

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
        }
    }
}
