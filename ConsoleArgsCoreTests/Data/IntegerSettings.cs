using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleArgsCoreTests.Data
{
	[Usage("Usage: Test.exe -i <int>,<int>,<int> -q <int> -w <int>")]
	public class IntegerSettings
	{
		[Argument('i', "List of integers.", Word = "input")]
		public int[] Integers { get; set; }

		[Argument('q', "List of integers.", Word = "byte")]
		public byte UInt8Value { get; set; }

		[Argument('w', "List of integers.", Word = "sbyte")]
		public sbyte Int8Value { get; set; }

		[Argument('e', "List of integers.", Word = "ushort")]
		public ushort UInt16Value { get; set; }

		[Argument('r', "List of integers.", Word = "short")]
		public short Int16Value { get; set; }

		[Argument('t', "List of integers.", Word = "uint")]
		public uint UInt32Value { get; set; }

		[Argument('y', "List of integers.", Word = "int")]
		public int Int32Value { get; set; }

		[Argument('u', "List of integers.", Word = "ulong")]
		public ulong UInt64Value { get; set; }

		[Argument('a', "List of integers.", Word = "long")]
		public long Int64Value { get; set; }
	}
}
