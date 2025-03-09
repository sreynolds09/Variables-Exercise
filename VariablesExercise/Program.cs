namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            String myName = "Sara";
            int myAge = 30;
            char middleInitial = 'C';
            double myShowsWatched = 1400.0;
            decimal myTimeSpent = 30000.00m;
            bool hasDog = true;
            Console.WriteLine($"My Name is {myName}. I am {myAge} years old. My Middle Name begins with {middleInitial}.The number of shows I've watched is {myShowsWatched}.The amount of time I have spent watching shows is {myTimeSpent}.I have a dog {hasDog}");
        }
    }
}
