//********************************************************************************************************************************
// Filename:    StringGoPathTests.cs
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
	public class StringGoPathTests
	{
		[TestMethod]
		public void SingleDashEqualString()
		{
			StringSettings settings = new StringSettings();
			Assert.IsNull(settings.InputFile);
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);

			ConsoleArgs<StringSettings>.Populate("ConsoleArgs.dll -i=myfile.in", settings);

			Assert.IsNotNull(settings.InputFile);
			Assert.IsTrue(settings.InputFile == "myfile.in");
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);
		}

		[TestMethod]
		public void SingleDashSpaceString()
		{
			StringSettings settings = new StringSettings();
			Assert.IsNull(settings.InputFile);
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);

			ConsoleArgs<StringSettings>.Populate("ConsoleArgs.dll -i myfile.in", settings);

			Assert.IsNotNull(settings.InputFile);
			Assert.IsTrue(settings.InputFile == "myfile.in");
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);
		}


		[TestMethod]
		public void DualDashEqualString()
		{
			StringSettings settings = new StringSettings();
			Assert.IsNull(settings.InputFile);
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);

			ConsoleArgs<StringSettings>.Populate("ConsoleArgs.dll --i=myfile.in", settings);

			Assert.IsNotNull(settings.InputFile);
			Assert.IsTrue(settings.InputFile == "myfile.in");
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);
		}

		[TestMethod]
		public void DualDashSpaceString()
		{
			StringSettings settings = new StringSettings();
			Assert.IsNull(settings.InputFile);
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);

			ConsoleArgs<StringSettings>.Populate("ConsoleArgs.dll --i myfile.in", settings);

			Assert.IsNotNull(settings.InputFile);
			Assert.IsTrue(settings.InputFile == "myfile.in");
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);
		}

		[TestMethod]
		public void MixDashMultipleEqualStrings()
		{
			StringSettings settings = new StringSettings();
			Assert.IsNull(settings.InputFile);
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);

			ConsoleArgs<StringSettings>.Populate("ConsoleArgs.dll -i=myfile.in --o=outfile.out", settings);

			Assert.IsNotNull(settings.InputFile);
			Assert.IsTrue(settings.InputFile == "myfile.in");
			Assert.IsNotNull(settings.OutputFile);
			Assert.IsTrue(settings.OutputFile == "outfile.out");
			Assert.IsNull(settings.ConfigFiles);
		}

		[TestMethod]
		public void MixedDashMultipleEqualStringsWithWords()
		{
			StringSettings settings = new StringSettings();
			Assert.IsNull(settings.InputFile);
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);

			ConsoleArgs<StringSettings>.Populate("ConsoleArgs.dll -input=myfile.in --output=outfile.out", settings);

			Assert.IsNotNull(settings.InputFile);
			Assert.IsTrue(settings.InputFile == "myfile.in");
			Assert.IsNotNull(settings.OutputFile);
			Assert.IsTrue(settings.OutputFile == "outfile.out");
			Assert.IsNull(settings.ConfigFiles);
		}

		[TestMethod]
		public void MixedDashMultipleMixedStringsWithWords()
		{
			StringSettings settings = new StringSettings();
			Assert.IsNull(settings.InputFile);
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);

			ConsoleArgs<StringSettings>.Populate("ConsoleArgs.dll -input=myfile.in --o outfile.out", settings);

			Assert.IsNotNull(settings.InputFile);
			Assert.IsTrue(settings.InputFile == "myfile.in");
			Assert.IsNotNull(settings.OutputFile);
			Assert.IsTrue(settings.OutputFile == "outfile.out");
			Assert.IsNull(settings.ConfigFiles);
		}

		[TestMethod]
		public void MixedDashMultipleSpaceStringsWithWords()
		{
			StringSettings settings = new StringSettings();
			Assert.IsNull(settings.InputFile);
			Assert.IsNull(settings.OutputFile);
			Assert.IsNull(settings.ConfigFiles);

			ConsoleArgs<StringSettings>.Populate("ConsoleArgs.dll -input myfile.in --o outfile.out", settings);

			Assert.IsNotNull(settings.InputFile);
			Assert.IsTrue(settings.InputFile == "myfile.in");
			Assert.IsNotNull(settings.OutputFile);
			Assert.IsTrue(settings.OutputFile == "outfile.out");
			Assert.IsNull(settings.ConfigFiles);
		}
	}
}
