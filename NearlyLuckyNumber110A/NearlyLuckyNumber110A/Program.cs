using System;

namespace NearlyLuckyNumber110A
{
    class Program
    {
        static void Main(string[] args)
        {
            string number =Console.ReadLine();
            Console.WriteLine(isLucky(number));
        }

        public static string isLucky(string number)
        {
            string trueFalse = "NO";
            int counter = 0;
            
            for (int i = 0; i < number.Length; i++)
            {
                if(number[i] == '4' || number[i] == '7')
                {
                    counter++;
                }
            }

            if (counter == 4 || counter == 7)
            {
                trueFalse = "YES";
            }

            return trueFalse;
        }
    }
}
