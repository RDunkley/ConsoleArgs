using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleArgsCoreTests.Data
{
	[Usage("Usage: Test.exe -a --b -c --apple -baby --cardinals")]
	public class BooleanFlag
	{
		[Argument('a', "True if the test has an apple, false otherwise.", Word ="apple")]
		public bool Apple { get; set; }

		[Argument('b', "True if you lost your baby, false if the dingo ate it.", Word ="baby")]
		public bool Baby { get; set; }

		[Argument('c', "True if you like the cardinals, false otherwise.", Word ="cardinals")]
		public bool LikeCardinals { get; set; }
	}
}
