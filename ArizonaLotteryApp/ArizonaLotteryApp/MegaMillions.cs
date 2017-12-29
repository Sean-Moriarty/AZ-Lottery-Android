using System;
using System.Text;
namespace ArizonaLotteryApp
{
    public class MegaMillions
    {
        public static string MegaResults()
        {
            // Mega Milliions rules: 5 numbers from 1-75 and 
            // one Megaplier from 1-15.

			int[] numbers = new int[5];
			int megaplier;

			Random rand = new Random();
            var results = new StringBuilder();

            // Generate numbers and add them to "results" string

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 75);
                results.Append(numbers[i].ToString());
                results.Append(" ");
			}

            // Generate and add "megaplier" to "results" string
            megaplier = rand.Next(1, 15);

            results.Append("Megaplier: " + megaplier.ToString());

            return results.ToString();
        }
    }
}
