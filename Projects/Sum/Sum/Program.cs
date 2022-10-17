using System;

namespace Sum
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int number = 0, answer = 0;

            while (answer <= 200)
			{
				Console.Write("Sum is now " + answer + ". ");
				Console.Write("Input: ");

				number = Convert.ToInt32(Console.ReadLine());
				answer = answer + number;
			}

			Console.WriteLine("Reached 200. The total was " + answer + ".");

		}
	}
}
