using System;

namespace LetterLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some random letters.");
            string randomLetters = Console.ReadLine();

            string result = string.Empty;

            for (var i = 0; i < randomLetters.Length; i++)
            {
                char c = randomLetters[i];

                result += char.ToUpper(c);

                result += new string(char.ToLower(c), i);

                if (i < randomLetters.Length - 1)
                {
                    result += "-";
                }
            }
            Console.WriteLine(result);

        }
    }
}
