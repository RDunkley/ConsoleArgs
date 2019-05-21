using ConsoleArgsCoreTests.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleArgsCoreTests
{
	[TestClass]
	public class IntegerGoPathTests
	{
		[TestMethod]
		public void SingleItem()
		{
			IntegerSettings settings = new IntegerSettings();
			Assert.IsNull(settings.Integers);
			Assert.IsTrue(settings.UInt8Value == 0);
			Assert.IsTrue(settings.Int8Value == 0);
			Assert.IsTrue(settings.UInt16Value == 0);
			Assert.IsTrue(settings.Int16Value == 0);
			Assert.IsTrue(settings.UInt32Value == 0);
			Assert.IsTrue(settings.Int32Value == 0);
			Assert.IsTrue(settings.UInt64Value == 0);
			Assert.IsTrue(settings.Int64Value == 0);

			ConsoleArgs<IntegerSettings>.Populate("ConsoleArgs.dll -i 1,200,-3,345345", settings);

			Assert.IsNotNull(settings.Integers);
			Assert.IsTrue(settings.Integers.Length == 4);
			Assert.IsTrue(settings.Integers[0] == 1);
			Assert.IsTrue(settings.Integers[1] == 200);
			Assert.IsTrue(settings.Integers[2] == -3);
			Assert.IsTrue(settings.Integers[3] == 345345);
		}
	}
}
