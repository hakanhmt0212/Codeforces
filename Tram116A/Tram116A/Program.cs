using System;

namespace Tram116A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int stops = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Passangers(stops));
        }

        public static int Passangers(int stops)
        {

            int max_passengers = 0;
            int passangers = 0;

            for (int i = 0; i < stops; i++)
            {
                Console.WriteLine();
                string in_out = Console.ReadLine();
                string[] in_out_array = in_out.Split(" ");

                int first = Convert.ToInt32(in_out_array[0]);
                int second = Convert.ToInt32(in_out_array[1]);

                int result = second - first;
                passangers += result;

                if (passangers > max_passengers)
                    max_passengers = passangers;
            }

            return max_passengers;
        }
    }
}
