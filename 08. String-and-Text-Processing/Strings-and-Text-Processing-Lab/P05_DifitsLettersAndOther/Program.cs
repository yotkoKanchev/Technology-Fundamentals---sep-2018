using System;
using System.Text;

namespace P05_DifitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string digits = "";
            string letters = "";
            string others = "";

            for (int i = 0; i < inputText.Length; i++)
            {
                if (char.IsDigit(inputText[i]))
                {
                    digits += inputText[i];
                }
                else if (char.IsLetter(inputText[i]))
                {
                    letters += inputText[i];
                }
                else
                {
                    others += inputText[i];
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
