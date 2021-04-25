
# Project: Merge Interval

## Overview
This is a program to merge intervals sequences and output the resulting interval list on the command line.
E.g. 

[2,23] 

[25,30] 

The source list of intervals can be a string of intervals like "[25,30] [2,19] [14,23] [4,8]" or it can be
a cvs file where each line in the file is an interval. Start and end value is separated by a semicolon

The software is implemented in C# / .NET 5 and use nunit3 for the unit tests.

**PLEASE KEEP IN MIND THE FOCUS WAS ON THE MERGE FUNCTION**

There are some places in the code which needs to be improved on testing and error handling

## Quickstart
### Prerequisites

[Download and install .NET **SDK**](https://dotnet.microsoft.com/download)


If you just want to start up quickly the application, clone or download the source files, open a command line prompt in the src/MergeInterval folder and type

```
❯ dotnet run -- --help
```
This command will display you the program help as you can see it below
```
MergeInterval 1.0.0
Copyright (C) 2021 MergeInterval

  -c, --csv       (Group: IntervalSource) Read intervals from the specified cvs file.Caution filename has to be enclosed
                  with quotation marks

  -s, --string    (Group: IntervalSource) Read intervals the command line.Caution intervals have to be enclosed with
                  quotation marks E.g.: "[25,30] [2,19] [14, 23] [4,8]".

  --help          Display this help screen.

  --version       Display version information.
```

To get merged intervals use the following statement
```
dotnet run -- -s "[25,30] [2,19] [14, 23] [4,8]"
```

**This is just for testing and you are running a debug version. To get a distributable binary see the [build instructions](./doc/BuildInstructions.md) in the "doc" folder** 


If you already build or published binary call for example
```
MergeInterval -s "[25,30] [2,19] [14, 23] [4,8]"
```


## External dependencies
The project **MergeInterval** has an external dependency to [**CommandLineParser**  project https://github.com/commandlineparser/commandline](https://github.com/commandlineparser/commandline) to get and parse the command line argumeents easily 
 
 ## Further information
* [Project structure](./doc/ProjectStructure.md)
* [Coding task description](./doc/Coding-Task.md)
* [Build instructions](./doc/BuildInstructions.md)
* [Running unit tests](./doc/UnitTests.md)

