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
                Console.WriteLine("1. The price of a bio ticket" +
                                "\n2. The price of several bio tickets" +
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
                        Cinema();
                        break;
                    case 2:
                        CinemaGroup();
                        break;
                    case 3:
                        TenTimes();
                        break;
                    case 4:
                        The3rd();
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

        // Print the 3rd word
        private static void The3rd()
        {
            Console.Write("Write at least 3 words: ");
            string[] words = Console.ReadLine()!.Split(" ");
            Console.WriteLine("The 3rd word is: " + words[2]);
            Console.WriteLine();
        }

        // Print a word ten times
        private static void TenTimes()
        {
            Console.Write("Write a word: ");
            string word = Console.ReadLine()!;
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + ". " + word + ", ");
            }
                Console.WriteLine("10. " + word + '.');
            Console.WriteLine();
        }

        // Figure out and print the price of one bio ticket for the selected age
        private static void Cinema()
        {
            Console.Write("Enter the age of the viewer: ");
            int age = int.Parse(Console.ReadLine()!);
            if (age < 20)
                Console.WriteLine("Youth price: SEK 80"); 
            else if (age > 64)
                Console.WriteLine("Pensioner price: SEK 90");
            else
                Console.WriteLine("Standard price: SEK 120");
            Console.WriteLine();
        }

        // Figure out the total price of bio tickets for the selected ages
        private static void CinemaGroup()
        {
            Console.Write("Write how many you are going to the cinema: ");
            int companySize = int.Parse(Console.ReadLine()!);
            int[] ages = new int[companySize];
            Console.WriteLine("Enter the ages of the viewers (one/line):");
            for (int i = 0; i < companySize; i++)
            {
                ages[i] = int.Parse(Console.ReadLine()!);
            }
            // Calculate the total price
            int sum = 0;
             for (int i = 0; i < companySize; i++)
            {
               sum += Cinema(ages[i]);
            }
            Console.WriteLine("The total price is: SEK " + sum);
            Console.WriteLine();
        }

        // Figure out the price of one bio ticket for a given age
        private static int Cinema(int age)
        {
            if (age < 20)
                return 80;
            else if (age > 64)
                return 90;
            else
                return 120;
        }
    }
}
