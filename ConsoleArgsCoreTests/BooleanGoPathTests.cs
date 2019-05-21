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
