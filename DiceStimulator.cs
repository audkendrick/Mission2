using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DiceStimulator
{
    private Random randomnum;
    public DiceStimulator()
    {
            randomnum = new Random();
    }
    public int[] RollDice(int numrolls)
    {
        //Create array to hold count of sums of dice
        int[] rollCounts = new int[13];

        // for # of times user entered
        for (int i = 0; i < numrolls; i++)
        {
            // Roll die 1, collect result
            int diceRoll = randomnum.Next(1, 7); // Generates a number from 1 to 6 (inclusive)

            // roll die 2, collect result
            int diceRoll2 = randomnum.Next(1, 7); // Generates a number from 1 to 6 (inclusive)

            // Add together and store result
            int totalDiceRoll = diceRoll + diceRoll2;
            rollCounts[totalDiceRoll]++;
        }

        return rollCounts;

    }
}

// CLASS 2
// For each # possible to be rolled
// print the number
// Calculate the percentage of times it was rolled
// print * for each percent it was rolled
//( method to sub character for number)



