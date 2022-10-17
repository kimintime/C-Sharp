using System;

namespace program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = 1;

            if ((a != b) && (a < b))
            {
                if (a > c)
                {
                    Console.WriteLine("Success!");
                }     
            }

            else
            {
                Console.WriteLine("Try once more!");
            }
        }
    }
}
