using System;
using System.IO;

namespace appendFile
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string filename;
			string content;

			Console.Write("Append to file: ");
			filename = Console.ReadLine();

			Console.WriteLine("Provide the content for " + filename + ":");
            content = Console.ReadLine();

			using (StreamWriter sw = new StreamWriter(filename, true))
			{
				sw.WriteLine(content);
				sw.Close();
			}
		}
	}
}
