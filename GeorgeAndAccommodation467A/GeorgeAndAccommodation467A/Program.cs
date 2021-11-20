using System;

namespace GeorgeAndAccommodation467A
{
    class Program
    {
        static void Main(string[] args)
        {
            int rooms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(freePlace(rooms));
        }

        public static int freePlace(int rooms)
        {
            int freeRoom = 0;

            for (int i = 0; i < rooms; i++)
            {
                string input = Console.ReadLine();
                string[] array = input.Split(" ");

                int people = (Convert.ToInt32(array[1]) - Convert.ToInt32(array[0]));

                if (people >= 2)
                {
                    freeRoom++;
                }
            }

            return freeRoom;
        }
    }
}
