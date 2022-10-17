using System;

namespace PrintNumbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int count, i = 1, j = 0, number = 0;
			count = Convert.ToInt32(args[0]);

			do
			{
                number = i;
                Console.WriteLine(number + "\r");
				i++;

				for (j = 1; j <= number; j++)
				{
					Console.Write(j);

					if (j == count - 1)
						Console.Write(j + 1);

				}
            } while (i < count);
		}
	}
}

