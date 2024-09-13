using System;

namespace Labb01___Algoritmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter text: ");
            string userString = "29535123p48723487597645723645"; //Console.ReadLine();

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

                string[] colorMode = userString.Split(subString, StringSplitOptions.None); //blir tokig!

                Console.Write(colorMode[0]);
                Console.WriteLine(colorMode[2]);
                Console.Write(colorMode[1]);
            }

            //Console.WriteLine(sumOfAllSubstrings);
        }
    }
}
