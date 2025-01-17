using System;

internal class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Dice Roll Simulation!");
        // Ask user how many times to roll the dice
        System.Console.WriteLine("Please enter how many times you want to roll the dice");
        
        // Get the number of rolls from the user
        if (!int.TryParse(Console.ReadLine(), out int numrolls) || numrolls <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }
        // Create instance of DiceStimulator to link class
        DiceStimulator diceStimulator = new DiceStimulator();

        // Create dice roll
        int[] rollResults = diceStimulator.RollDice(numrolls);

        // Print out the histogram results
        DisplayHistogram(rollResults, numrolls);

        // Print the goodbye message
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }
    private static void DisplayHistogram(int[] rollResults, int totalRolls)
    {
        Console.WriteLine("\nResults of Dice Rolling Stimulation:");
        Console.WriteLine("Each * represents 1% of the total number of rolls.  ");
        Console.WriteLine("\nThe total number of rolls was " + totalRolls);
        for (int i = 2; i <= 12; i++)
        {
            int count = rollResults[i];
            double percentage = ((double)count / totalRolls) * 100;

            // Generate histogram where each * represents 1%

            string bar = new string('*', (int)percentage);

            Console.WriteLine($"{i}: {bar} ");
        }
    }
}
