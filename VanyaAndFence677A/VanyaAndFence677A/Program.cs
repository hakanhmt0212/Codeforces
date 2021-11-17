using System;

namespace VanyaAndFence677A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string heightofPerson = Console.ReadLine();

            string[] vs = input1.Split(" ");
            int friends = Convert.ToInt32(vs[0]);
            int heightFence = Convert.ToInt32(vs[1]);

            Console.WriteLine(width(friends, heightFence, heightofPerson));
        }

        public static int width(int friends, int wallHeight, string personHeight)
        {
            int result = friends;
            string[] array = personHeight.Split(" ");

            for (int i = 0; i < array.Length; i++)
            {
                int height = Convert.ToInt32(array[i]);

                if (height > wallHeight)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
