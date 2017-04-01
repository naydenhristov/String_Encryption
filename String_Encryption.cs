using System;

namespace Task1_8_String_Encryption
{
    class String_Encryption
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[] chars = new char[n];

            for (int i = 0; i < n; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }

            string result = string.Empty;

            foreach (int ch in chars)
            {
                result += Encrypt(ch);
            }

            Console.WriteLine(result);
        }

        static string Encrypt(int letter)
        {
            int firstDigit = 0, lastDigit, number, asciiNumber1, asciiNumber2;

            lastDigit = letter % 10;
            number = letter;
            
            while (number > 0)
            {
                firstDigit = number;
                number /= 10;
            }

            asciiNumber1 = letter + lastDigit;
            asciiNumber2 = letter - firstDigit;

            string result = ((char)asciiNumber1 + Convert.ToString(firstDigit) +
                Convert.ToString(lastDigit) + (char)asciiNumber2).ToString();
            
            return result;
        }
    }
}
