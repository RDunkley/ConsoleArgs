//********************************************************************************************************************************
// Filename:    BooleanGoPathTests.cs
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
	public class BooleanGoPathTests
	{
		[TestMethod]
		public void SingleDashBooleanFlag()
		{

			BooleanFlag flag = new BooleanFlag();
			Assert.IsFalse(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
			ConsoleArgs<BooleanFlag>.Populate("ConsoleArgs.dll -a", flag);

			// Validate the populated settings.
			Assert.IsTrue(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
		}

		[TestMethod]
		public void DoubleDashBooleanFlag()
		{

			BooleanFlag flag = new BooleanFlag();
			Assert.IsFalse(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
			ConsoleArgs<BooleanFlag>.Populate("ConsoleArgs.dll --a", flag);

			// Validate the populated settings.
			Assert.IsTrue(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
		}

		[TestMethod]
		public void SingleDashBooleanWord()
		{

			BooleanFlag flag = new BooleanFlag();
			Assert.IsFalse(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
			ConsoleArgs<BooleanFlag>.Populate("ConsoleArgs.dll -apple", flag);

			// Validate the populated settings.
			Assert.IsTrue(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
		}

		[TestMethod]
		public void DoubleDashBooleanWord()
		{

			BooleanFlag flag = new BooleanFlag();
			Assert.IsFalse(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
			ConsoleArgs<BooleanFlag>.Populate("ConsoleArgs.dll --apple", flag);

			// Validate the populated settings.
			Assert.IsTrue(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
		}

		[TestMethod]
		public void MultipleBooleanFlags()
		{

			BooleanFlag flag = new BooleanFlag();
			Assert.IsFalse(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
			ConsoleArgs<BooleanFlag>.Populate("ConsoleArgs.dll -a --b -c", flag);

			// Validate the populated settings.
			Assert.IsTrue(flag.Apple);
			Assert.IsTrue(flag.Baby);
			Assert.IsTrue(flag.LikeCardinals);
		}

		[TestMethod]
		public void MultipleBooleanWords()
		{

			BooleanFlag flag = new BooleanFlag();
			Assert.IsFalse(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
			ConsoleArgs<BooleanFlag>.Populate("ConsoleArgs.dll -apple --baby -cardinals", flag);

			// Validate the populated settings.
			Assert.IsTrue(flag.Apple);
			Assert.IsTrue(flag.Baby);
			Assert.IsTrue(flag.LikeCardinals);
		}

		[TestMethod]
		public void MultipleBooleanMixed()
		{

			BooleanFlag flag = new BooleanFlag();
			Assert.IsFalse(flag.Apple);
			Assert.IsFalse(flag.Baby);
			Assert.IsFalse(flag.LikeCardinals);
			ConsoleArgs<BooleanFlag>.Populate("ConsoleArgs.dll -a --baby --c", flag);

			// Validate the populated settings.
			Assert.IsTrue(flag.Apple);
			Assert.IsTrue(flag.Baby);
			Assert.IsTrue(flag.LikeCardinals);
		}
	}
}
