namespace Övning_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello! You have reached the main menu. Please " +
                "enter from the following digits to test various functions.");
                Console.WriteLine("1. Buy a bio ticket" +
                                "\n2. Buy several bio tickets" +
                                "\n3. Repeat a word ten times" +
                                "\n4. The third word in a sentence" +
                                "\n0. Quit");

                string input = Console.ReadLine()!;
                if (!int.TryParse(input, out int parsedInt))
                {
                    Console.WriteLine("That was not a digit!");
                    Console.WriteLine();
                    continue;
                }
                switch (parsedInt)
                {
                    case 1:
                        bio();
                        break;
                    case 2:
                        bioGroup();
                        break;
                    case 3:
                        tenTimes();
                        break;
                    case 4:
                        the3rd();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not a valid selection!");
                        break;
                }
            }
        }

        private static void the3rd()
        {
            Console.WriteLine("Write at least 3 words: ");
            string[] words = Console.ReadLine()!.Split(" ");
            Console.WriteLine("The 3rd word is: " + words[2]);
            Console.WriteLine();
        }

        private static void tenTimes()
        {
            Console.WriteLine("Write a word: ");
            string word = Console.ReadLine()!;
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + ". " + word + ", ");
            }
                Console.Write("10. " + word + '.');
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void bio()
        {
            throw new NotImplementedException();
        }

        private static void bioGroup()
        {
            throw new NotImplementedException();
        }
    }
}
