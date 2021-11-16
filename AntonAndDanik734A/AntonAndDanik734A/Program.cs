using System;

namespace AntonAndDanik734A
{
    class Program
    {
        static void Main(string[] args)
        {
            int game = Convert.ToInt32(Console.ReadLine());
            string wins = Console.ReadLine();
            Console.WriteLine(winner(game, wins));
        }

        public static string winner(int game, string wins)
        {
            int counterA = 0;
            int counterD = 0;

            for (int i = 0; i < game; i++)
            {
                if (wins[i] == 'A')
                {
                    counterA++;
                }
                else
                {
                    counterD++;
                }
            }

            if (counterA > counterD)
            {
                return "Anton";
            }
            else if (counterD > counterA)
            {
                return "Danik";
            }
            else
            {
                return "Friendship";
            }
        }
    }
}
