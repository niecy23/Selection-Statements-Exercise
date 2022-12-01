namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var FavoriteNumber = 23;

            Console.WriteLine("Try to guess my favorite number");
            var UserGuess = int.Parse(Console.ReadLine());

            if (UserGuess < FavoriteNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (UserGuess > FavoriteNumber)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
        }
    }
}
