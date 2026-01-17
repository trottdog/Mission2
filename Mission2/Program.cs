namespace Mission2;
internal class Program
{
    public static void Main(string[] args)
    {
        // Welcomes players and requests roll count
        int rolls = GetRollCount();
        // Initializes roll object from the DiceRoll class
        DiceRoll roll = new DiceRoll();
        // Calls the RollDice method within the DiceRoll class and assigns array values that are returned
        int[] counts = roll.RollDice(rolls);
        
        PrintHistogram(rolls, counts);
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
    private static int GetRollCount()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        
        return int.Parse(Console.ReadLine());
    }

    private static void PrintHistogram(int rolls,  int[] counts)
    {
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + rolls +".\n");
        
        for(int sum = 2; sum <= 12; sum++)
        {
            var percent = (counts[sum] / (double)rolls) * 100;
            var stars = (int)Math.Round(percent);
            
            Console.WriteLine($"{sum}: {new string('*', stars)}");
        }
    }
}