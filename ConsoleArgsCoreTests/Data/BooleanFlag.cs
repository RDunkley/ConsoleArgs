//********************************************************************************************************************************
// Filename:    BooleanFlag.cs
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
