namespace Labb01___Algoritmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter text: ");
            string userString = "12341567p83812453"; //Console.ReadLine();

            int equalIndex = 0;
            ulong sumOfAllSubstrings = 0;

            for (int i = 0; i < userString.Length; i++)
            {
                //equalIndex = userString.IndexOf(userString);

                Console.Write(userString[i]);
            }
        }
    }
}
