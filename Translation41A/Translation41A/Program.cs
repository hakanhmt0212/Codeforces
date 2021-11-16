using System;

namespace Translation41A
{
    class Program
    {
        static void Main(string[] args)
        {
            string berland = Console.ReadLine();
            string birland = Console.ReadLine();

            Console.WriteLine(berlandToBirland(berland, birland));
        }

        public static string Reverser(string str)
        {
            char[] array = str.ToCharArray();
            char[] result = new char[array.Length];

            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = array[j];
            }

            return new string(result);
        }

        public static string berlandToBirland(string strBE, string strBI)
        {
            string yesNo = "NO";
            string result = Reverser(strBE);

            if (result == strBI)
            {
                yesNo = "YES";
            }

            return yesNo;
        }
    }
}
