using System;
using System.Data.SqlTypes;

namespace Labb01___Algoritmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in din text: ");
            string userString = Console.ReadLine();
            Console.WriteLine();

            int equalIndex = 0;
            ulong sumOfAllSubstrings = 0;

            for (int i = 0; i < userString.Length; i++)
            {
                equalIndex = userString.IndexOf(userString[i], i + 1);
                string subString = string.Empty;

                for (int j = i; j <= equalIndex; j++)
                {
                    if (char.IsDigit(userString[j]))
                        subString += userString[j];
                    else
                    {
                        subString = string.Empty;
                        break;
                    }
                }
                if (subString == string.Empty)
                    continue;

                sumOfAllSubstrings += ulong.Parse(subString);

                string[] splitArray = userString.Split(subString);

                Console.Write(splitArray[0]);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(subString);
                Console.ResetColor();
                Console.Write(splitArray[1]);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Summan av substrängarna är: {sumOfAllSubstrings}");
        }
    }
}
