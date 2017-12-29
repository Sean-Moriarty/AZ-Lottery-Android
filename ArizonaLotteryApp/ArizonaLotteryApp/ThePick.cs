using System;
using System.Text;
namespace ArizonaLotteryApp
{
    public class ThePick
    {
        public static string PickResults()
        {
            // The Pick rules: pick 6 numbers from 1-44.
			int[] numbers = new int[6];

			Random rand = new Random();
            var results = new StringBuilder();

            // Generate numbers and add them to results string.

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = rand.Next(1, 44);
                results.Append(numbers[i].ToString());
                results.Append(" ");
			}

            return results.ToString();
        }
    }
}
