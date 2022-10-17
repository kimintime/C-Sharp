using System;

namespace NukeFootCockroach
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int computer;
            bool gameOn = true;
            string userchose;

            Random random = new Random();

            while (gameOn)
            {
                Console.Write("Cockroach-Foot-Nuke. Choose 1-4.\n1) Cockroach 2) Foot 3) Nuke 4) Exit: ");
                userchose = Console.ReadLine();
                computer = random.Next(1, 4);

                if (userchose == "1")
                    Console.WriteLine(userchose + " Cockroach!");

                else if (userchose == "2")
                    Console.WriteLine(userchose + " Foot!");

                else if (userchose == "3")
                    Console.WriteLine(userchose + " Nuke!");

                else if (userchose == "4")
                {
                    Console.WriteLine(userchose);
                    gameOn = false;
                }

                if ((computer == 1) && (userchose == "1" || userchose == "2" || userchose == "3"))
                    Console.Write("Computer had Cockroach. ");

                else if ((computer == 2) && (userchose == "1" || userchose == "2" || userchose == "3" ))
                    Console.Write("Computer had Foot. ");

                else if ((computer == 3) && (userchose == "1" || userchose == "2" || userchose == "3"))
                    Console.Write("Computer had Nuke. ");

                if ((computer == 2 && userchose == "1") || (computer == 3 && userchose == "2") || (computer == 1 && userchose == "3"))
                    Console.WriteLine("You LOSE!");

                else if ((computer == 3 && userchose == "1") || (computer == 1 && userchose == "2") || (computer == 2 && userchose == "3"))
                    Console.WriteLine("You WIN!");

                else if ((computer == 1 && userchose == "1") || (computer == 2 && userchose == "2") || (computer == 3 && userchose == "3"))
                    Console.WriteLine("It's a Tie!");

                else if (userchose != "4")
                    Console.WriteLine("Incorrect selection.");

            }
        }
    }
}
