namespace CasinoGameNumberGuessingProgram
{
    class Program
    {
        static void GuessingGame()
        {
            int money = 100;
            System.Console.WriteLine($"\nYou have {money} points by default.\nYou lose them if you guess the wrong number.");
            System.Console.WriteLine("\n\nI am thinking of a number. Can you guess it?\nIf you do then you will get 150% percent (added) the amount of points.\n");
            System.Random random_number = new System.Random();
            int secret_number = random_number.Next(1, 101);
            while(true)
            {
                System.Console.Write("Enter a number: ");
                int input_number = System.Convert.ToInt32(System.Console.ReadLine());
                if(input_number > secret_number)
                {
                    System.Console.WriteLine("The secret number is lower\n");
                    money -= 10;
                    continue;
                }
                else if(input_number < secret_number)
                {
                    System.Console.WriteLine("The secret number is higher");
                    money -= 10;
                    continue;
                }
                else
                {
                    System.Console.WriteLine("You guessed the number\n");
                    System.Console.WriteLine($"You had {1.5 * money} points at the end of the round");
                    break;
                }
            }
        }
        static void hand()
        {
            while (true)
            {
                System.Console.Write(">>>");
                string input = System.Console.ReadLine();
                if (input == "game") { GuessingGame(); break; }
                else if (input == "exit") { break; }
                else { System.Console.WriteLine($"{input} is not an acceptable command"); continue; }
            }
        }
        static void Main(string[] args)
        {
            hand();
        }
    }
}