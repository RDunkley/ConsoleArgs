using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleArgsCoreTests.Data
{
	[Usage("Usage: Test.exe -i=test.exe -o output.exe -c config1,config2")]
	public class StringSettings
	{
		[Argument('i', "Input file", Word ="input")]
		public string InputFile { get; set; }

		[Argument('o', "Output file", Word ="output")]
		public string OutputFile { get; set; }

		[Argument('c', "Config Files", Word ="config")]
		public string[] ConfigFiles { get; set; }
	}
}
