# ConsoleArgs

This class parses console arguments for you and places the arguments in a data structure class you define using C# attributes. The attributes also provide documentation so that command line help can also be automatically generated. Only the file /ConsoleArgs/ConsoleArgs.cs is required to add to your project (the remaining source in this repo is example usage code and unit tests).

For example, if CommandSettings is your data class and you want to parse arguments into that class you would add ConsoleArgs.cs to your project with the following code:

```
CommandSettings settings = new CommmandSettings();
ConsoleArgs<CommandSettings>.Populate(Environment.CommandLine, settings);
```

The Populate method tells the class to populate the 'settings' object with any command line arguments that have been found that match the attributes added to the CommandSettings class.

Help can be generated automatically by calling 'GenerateHelpText' method. For example:

```
ConsoleArgs<CommandSettings>.GenerateHelpText(Console.BufferWidth);
```

The line above will generate text on how to use the command line. Console.BufferWidth is passed in so that the lines will be wrapped appropriately.

## Attributes

ConsoleArgs.cs is designed to allow you to pass in any data class. It looks for attributes to assign the parsed command line values to. Multiple data classes can be used for various console arg parsing, but it is recommended to do one for the help file generation to work.

To enable a data class, add attributes to properties of your data class. The properties must have a public setter. The two attributes to add are 'Usage' and 'Argument'.

### Usage

This attribute goes on the class itself. It allows you to specify the usage of the application (see CommandSettings class in ConsoleArgs project). It also allows you to specify an example command line. These strings are only used when generating the help information.

Example:

```
[Usage("Reads an XML file and generates C# data classes.", "XMLToDataClass.exe [-g] [-e <settingsfile.x2dsettings>] -i <xmlfilepath> -o <outputfolder>")]
public class CommandSettings
{
	...
}
```

### Argument

Attach this attribute to a property that will store an argument parsed from the command line. Any data type can be used as long as the object can be converted from a string (built in types will parse from the string). Hexadecimal and binary values can also be used for integers.

For Example:

```
[Argument('i', "Input file that will be processed. Can be any input file.", Word = "input")]
public string InputFile { get; set; }

[Argument('h', "Preserve Hierarchy.", Word = "hierarchy")]
public bool PreserveHierarchy { get; set; }
```

When the class is passed into the Populate method it will store true in 'PreserveHierarchy' if a '-h' argument was found. It will also store a string value in 'InputFile' if a '-i' is found followed by a value. The value can be attached using an '=' character or a space. So both of these lines would be valid:

```
dotnet ./test.dll -h -i test.xml

dotnet ./test.dll -i=test.xml

```

## Examples

See the ./ConsoleArgsCoreTests/Data folder for more examples of data classes and the unit tests for command line examples. Hexadecimal values must be assigned to unsigned integer types (byte, ushort, uint, ulong) and be represented with a preceeding '0x' (0xf7) or followed by a 'h' (f7h). Binary numbers must be assigned to unsigned integer types as well and must be followed by a 'b' (1101101b). All integers can have underscores or commas to separate digits (Ex: 0x1234_5678 or 1,245,678).
