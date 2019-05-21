using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleArgsCoreTests.Data
{
	[Usage("Usage: Test.exe -i <file1> , <file2> , <file3>")]
	public class ArraySettings
	{
		[Argument('i', "List of input files.", Word ="input")]
		public string[] InputFiles { get; set; }
	}
}
