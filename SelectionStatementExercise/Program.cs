namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the correct number!");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var UpperLimit = int.Parse(Console.ReadLine());

            var random = new Random();
            var number = random.Next(1, UpperLimit);

            int UserGuess;
            do
            {
                Console.WriteLine("Enter your guess:");

                UserGuess = int.Parse(Console.ReadLine());

                if (UserGuess < number)
                {
                    Console.WriteLine("Your guess is too low. I'm sorry!");
                }
                else if (UserGuess > number)
                {
                    Console.WriteLine("Your guess is too high. I'm sorry!");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed it!");
                }
            } while (UserGuess != number);
        }
    }
}
