using System;
using System.Text;
namespace ArizonaLotteryApp
{
    public class PowerBall
    {
        public static string PowerResults()
        {
            // Power Ball rules: pick 5 numbers from 1-69 and
            // one Power Ball from 1-26
            int[] numbers = new int[5];
            int powerBall;

            Random rand = new Random();
            var results = new StringBuilder();

            // generate numbers and add them to results string
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 69);
                results.Append(numbers[i].ToString());
                results.Append(" "); 
            }

            // generate and add Power Ball to results string
            powerBall = rand.Next(1, 26);
            results.Append("Power Ball: " + powerBall.ToString());

            return results.ToString();
        }
    }
}
