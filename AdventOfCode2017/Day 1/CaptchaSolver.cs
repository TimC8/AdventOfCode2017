using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Descriptions:
//Part 1
//It goes on to explain that you may only leave by solving a captcha to prove you're not a human. Apparently, you only get one millisecond to solve the captcha: too fast for a normal human, but it feels like hours to you.

//The captcha requires you to review a sequence of digits(your puzzle input) and find the sum of all digits that match the next digit in the list.The list is circular, so the digit after the last digit is the first digit in the list.


//For example:

//1122 produces a sum of 3 (1 + 2) because the first digit(1) matches the second digit and the third digit(2) matches the fourth digit.
//1111 produces 4 because each digit (all 1) matches the next.
//1234 produces 0 because no digit matches the next.
//91212129 produces 9 because the only digit that matches the next one is the last digit, 9.

//Part 2
//Now, instead of considering the next digit, it wants you to consider the digit halfway around the circular list.That is, if your list contains 10 items, only include a digit in your sum if the digit 10/2 = 5 steps forward matches it.Fortunately, your list has an even number of elements.


//For example:

//1212 produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead.
//1221 produces 0, because every comparison is between a 1 and a 2.
//123425 produces 4, because both 2s match each other, but no other digit has a match.
//123123 produces 12.
//12131415 produces 4.
namespace AdventOfCode2017.Day_1
{
    public class CaptchaSolver
    {
        public String captchaInput { get; }
        int captchaSolution { get; set; }

        public CaptchaSolver(string captchaInput)
        {
            this.captchaInput = captchaInput ?? throw new ArgumentNullException(nameof(captchaInput));
        }

        public int SolveCaptcha(int indexDistance)
        {
            captchaSolution = 0;
            List<short> parsedCaptcha = ParseInput();
            int maxIndex = parsedCaptcha.Count() - 1;
            for (int i = 0; i <= maxIndex; i++)
            {
                int nextInd = (i + indexDistance) > maxIndex ? (i + indexDistance) % maxIndex - 1 : (i + indexDistance);
                if (parsedCaptcha[i] == parsedCaptcha[nextInd])
                {
                    captchaSolution += parsedCaptcha[i];
                }
            }
            return captchaSolution;
        }

        private List<short> ParseInput()
        {
            List<short> parsedInput = new List<short>();
            for (int i = 0; i < captchaInput.Length; i++)
            {
                short currentNum = 0;
                if (short.TryParse(captchaInput[i].ToString(), out currentNum))
                {
                    parsedInput.Add(currentNum);
                }

                else
                {
                    throw new ArgumentException("Only numbers are allowed in the argument");
                }
            }
            return parsedInput;
        }
    }
}
