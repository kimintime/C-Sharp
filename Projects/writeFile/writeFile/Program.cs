using System;
using System.IO;

namespace writeFile
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string filename, content;

			Console.Write("Filename to create: ");
			filename = Console.ReadLine();

			Console.WriteLine("Provide the content for " + filename + ":");
			content = Console.ReadLine();

			using (StreamWriter sw = new StreamWriter(filename))
			{
				sw.WriteLine(content);
				sw.Close();
			}
		}
	}
}
