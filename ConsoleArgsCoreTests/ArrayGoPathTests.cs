//********************************************************************************************************************************
// Filename:    ArrayGoPathTests.cs
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
	public class ArrayGoPathTests
	{
		[TestMethod]
		public void SingleItem()
		{
			ArraySettings settings = new ArraySettings();
			Assert.IsNull(settings.InputFiles);

			ConsoleArgs<ArraySettings>.Populate("ConsoleArgs.dll -i myfile.in", settings);

			Assert.IsNotNull(settings.InputFiles);
			Assert.IsTrue(settings.InputFiles[0] == "myfile.in");
		}

		[TestMethod]
		public void MultipleItems()
		{
			ArraySettings settings = new ArraySettings();
			Assert.IsNull(settings.InputFiles);

			ConsoleArgs<ArraySettings>.Populate("ConsoleArgs.dll -i file1.txt,file2.txt,file3.txt,file4.txt", settings);

			Assert.IsNotNull(settings.InputFiles);
			Assert.IsTrue(settings.InputFiles.Length == 4);
			Assert.IsTrue(settings.InputFiles[0] == "file1.txt");
			Assert.IsTrue(settings.InputFiles[1] == "file2.txt");
			Assert.IsTrue(settings.InputFiles[2] == "file3.txt");
			Assert.IsTrue(settings.InputFiles[3] == "file4.txt");
		}

		[TestMethod]
		public void MultipleItemsQuoted()
		{
			ArraySettings settings = new ArraySettings();
			Assert.IsNull(settings.InputFiles);

			ConsoleArgs<ArraySettings>.Populate("ConsoleArgs.dll -i \"file1.txt\",\"file2.txt\",\"file3.txt\",\"file4.txt\"", settings);

			Assert.IsNotNull(settings.InputFiles);
			Assert.IsTrue(settings.InputFiles.Length == 4);
			Assert.IsTrue(settings.InputFiles[0] == "file1.txt");
			Assert.IsTrue(settings.InputFiles[1] == "file2.txt");
			Assert.IsTrue(settings.InputFiles[2] == "file3.txt");
			Assert.IsTrue(settings.InputFiles[3] == "file4.txt");
		}

		[TestMethod]
		public void MultipleItemsQuotedWithSpaces()
		{
			ArraySettings settings = new ArraySettings();
			Assert.IsNull(settings.InputFiles);

			ConsoleArgs<ArraySettings>.Populate("ConsoleArgs.dll -i \"file 1.txt\",\"file 2.txt\",\"file 3.txt\",\"file 4.txt\"", settings);

			Assert.IsNotNull(settings.InputFiles);
			Assert.IsTrue(settings.InputFiles.Length == 4);
			Assert.IsTrue(settings.InputFiles[0] == "file 1.txt");
			Assert.IsTrue(settings.InputFiles[1] == "file 2.txt");
			Assert.IsTrue(settings.InputFiles[2] == "file 3.txt");
			Assert.IsTrue(settings.InputFiles[3] == "file 4.txt");
		}

		[TestMethod]
		public void MultipleItemsQuotedWithSpacesInsideAndOut()
		{
			ArraySettings settings = new ArraySettings();
			Assert.IsNull(settings.InputFiles);

			ConsoleArgs<ArraySettings>.Populate("ConsoleArgs.dll -i \"file 1.txt\" , \"file 2.txt\" , \"file 3.txt\" , \"file 4.txt\"", settings);

			Assert.IsNotNull(settings.InputFiles);
			Assert.IsTrue(settings.InputFiles.Length == 4);
			Assert.IsTrue(settings.InputFiles[0] == "file 1.txt");
			Assert.IsTrue(settings.InputFiles[1] == "file 2.txt");
			Assert.IsTrue(settings.InputFiles[2] == "file 3.txt");
			Assert.IsTrue(settings.InputFiles[3] == "file 4.txt");
		}

		[TestMethod]
		public void MultipleItemsQuotedWithInternalComma()
		{
			ArraySettings settings = new ArraySettings();
			Assert.IsNull(settings.InputFiles);

			ConsoleArgs<ArraySettings>.Populate("ConsoleArgs.dll -i \"file 1 ,with comma text,.txt\" , \"file 2 ,hi, test.txt\" , \"file 3.txt\" , \"file 4.txt\"", settings);

			Assert.IsNotNull(settings.InputFiles);
			Assert.IsTrue(settings.InputFiles.Length == 4);
			Assert.IsTrue(settings.InputFiles[0] == "file 1 ,with comma text,.txt");
			Assert.IsTrue(settings.InputFiles[1] == "file 2 ,hi, test.txt");
			Assert.IsTrue(settings.InputFiles[2] == "file 3.txt");
			Assert.IsTrue(settings.InputFiles[3] == "file 4.txt");
		}
	}
}
