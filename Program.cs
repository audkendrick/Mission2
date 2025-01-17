using System;
// Audra Kendrick
// Professor Hilton
// Create a Dice Rolling Stimulation


// Create Initial Program class
internal class Program
{
    // Create Main Method
    public static void Main(string[] args)
    {
        // Welcome the user to the stimulation
        Console.WriteLine("Welcome to the Dice Roll Stimulation!");

        // Ask user how many times to roll the dice
        System.Console.WriteLine("Please enter how many times you want to roll the dice");
        
        // Get the number of rolls from the user
        // Error Handling to ensure the user enters a valid number
        if (!int.TryParse(Console.ReadLine(), out int numrolls) || numrolls <= 0)
        {
            // If invalid input, prompt the user to enter a different one
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }
        // Create instance of DiceStimulator to link to DiceStimulator class
        DiceStimulator diceStimulator = new DiceStimulator();

        // Create dice roll
        int[] rollResults = diceStimulator.RollDice(numrolls);

        // Print out the histogram results
        DisplayHistogram(rollResults, numrolls);

        // Print the goodbye message
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }
    // Method to display histogram results
    // Also to sub character for number)
    private static void DisplayHistogram(int[] rollResults, int totalRolls)
    {
        // Label the table and results
        Console.WriteLine("\nResults of Dice Rolling Stimulation:");
        Console.WriteLine("Each * represents 1% of the total number of rolls.  ");
        Console.WriteLine("\nThe total number of rolls was " + totalRolls);
        
        // Create loop to create the percentages of each roll and display them
        for (int i = 2; i <= 12; i++)
        {
            int count = rollResults[i];
            double percentage = ((double)count / totalRolls) * 100;

            // Generate histogram where each * represents 1%
            string bar = new string('*', (int)percentage);

            // Print the histogram
            Console.WriteLine($"{i}: {bar} ");
        }
    }
}
