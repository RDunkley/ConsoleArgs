//********************************************************************************************************************************
// Filename:    IntegerGoPathTests.cs
// Owner:       Richard Dunkley
//********************************************************************************************************************************
// Copyright © Richard Dunkley 2019
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the
// License. You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0  Unless required by applicable
// law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//********************************************************************************************************************************
using ConsoleArgsCoreTests.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

		[TestMethod]
		public void HexValues()
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

			ConsoleArgs<IntegerSettings>.Populate("ConsoleArgs.dll -q 0x21 -e 0x2345 -t 0x12345678 -u 0x9876543212345678", settings);

			Assert.IsTrue(settings.UInt8Value == 0x21);
			Assert.IsTrue(settings.UInt16Value == 0x2345);
			Assert.IsTrue(settings.UInt32Value == 0x12345678);
			Assert.IsTrue(settings.UInt64Value == 0x9876543212345678);

			ConsoleArgs<IntegerSettings>.Populate("ConsoleArgs.dll -q=21h -e=2345h -t=1234_5678h -u=9876_5432_1234_5678h", settings);

			Assert.IsTrue(settings.UInt8Value == 0x21);
			Assert.IsTrue(settings.UInt16Value == 0x2345);
			Assert.IsTrue(settings.UInt32Value == 0x12345678);
			Assert.IsTrue(settings.UInt64Value == 0x9876543212345678);

			ConsoleArgs<IntegerSettings>.Populate("ConsoleArgs.dll -j 0x2345,0x15,2h,12345678h", settings);

			Assert.IsNotNull(settings.UInts);
			Assert.IsTrue(settings.UInts.Length == 4);
			Assert.IsTrue(settings.UInts[0] == 0x2345);
			Assert.IsTrue(settings.UInts[1] == 0x15);
			Assert.IsTrue(settings.UInts[2] == 0x2);
			Assert.IsTrue(settings.UInts[3] == 0x12345678);
		}

		[TestMethod]
		public void BinaryValues()
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

			ConsoleArgs<IntegerSettings>.Populate("ConsoleArgs.dll -q 10_0001b -e 0010_0011_0100_0101b -t 1_0010_0011_0100_0101_0110_0111_1000b -u 1001_1000_0111_0110_0101_0100_0011_0010_0001_0010_0011_0100_0101_0110_0111_1000b", settings);

			Assert.IsTrue(settings.UInt8Value == 0x21);
			Assert.IsTrue(settings.UInt16Value == 0x2345);
			Assert.IsTrue(settings.UInt32Value == 0x12345678);
			Assert.IsTrue(settings.UInt64Value == 0x9876543212345678);

			ConsoleArgs<IntegerSettings>.Populate("ConsoleArgs.dll -j 0010_0011_0100_0101b,00010101b,10b,1_0010_0011_0100_0101_0110_0111_1000b", settings);

			Assert.IsNotNull(settings.UInts);
			Assert.IsTrue(settings.UInts.Length == 4);
			Assert.IsTrue(settings.UInts[0] == 0x2345);
			Assert.IsTrue(settings.UInts[1] == 0x15);
			Assert.IsTrue(settings.UInts[2] == 0x2);
			Assert.IsTrue(settings.UInts[3] == 0x12345678);
		}
	}
}
