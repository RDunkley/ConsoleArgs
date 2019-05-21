using System;
using XMLToDataClass;

namespace ConsoleArgs
{
	class Program
	{
		static void Main(string[] args)
		{
			CommandSettings settings = new CommandSettings();
			ConsoleArgs<CommandSettings>.Populate(Environment.CommandLine,settings);

			Console.WriteLine("Hello World!");
		}
	}
}
