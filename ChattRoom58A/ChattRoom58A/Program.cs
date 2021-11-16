using System;

namespace ChattRoom58A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            isHello(str);
        }

        public static void isHello(string str)
        {
            char[] charArray = {'h', 'e', 'l', 'l', 'o'};
            string hello = "";
            int index = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = index; j < str.Length; j++)
                {
                    if (charArray[i] == str[j])
                    {
                        hello += str[j];
                        index = j + 1;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (hello == "hello")
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            
        }
    }
}
