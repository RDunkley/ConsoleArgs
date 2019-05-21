//********************************************************************************************************************************
// Filename:    StringSettings.cs
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
using System;

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
