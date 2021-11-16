using System;

namespace LuckyDivision122A
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(isLucky(number));
        }

        public static string isLucky(string number)
        {
            int[] luckyNumbers = { 4, 7, 44, 47, 74, 77, 444, 447, 474, 477, 744, 747, 774, 777 };
            string yesNo = "YES";

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '4' || number[i] == '7')
                    continue;
                else
                    yesNo = "NO";
            }

            int copyNumber = Convert.ToInt32(number);

            if (yesNo == "NO")
            {
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    if ((copyNumber % luckyNumbers[i] == 0))
                    {
                        yesNo = "YES";
                    }
                    else
                        continue;
                }
            }
            

            return yesNo;
        }
    }
}
