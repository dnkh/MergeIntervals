## Build instructions
### Prerequisites

[Download and install .NET **SDK**](https://dotnet.microsoft.com/download)

### Build the project
To build the project, open a command line prompt in the src/MergeInterval folder and type:

```
dotnet build -c Release
```
this will restore all external dependencies from nuget.org and build referenced libraries and the console app. You will find the output in **bin\Release\net5.0** folder

### Publish the project
To publish the project open a command line prompt in the src/MergeInterval folder and type:

```
dotnet publish -c Release -o ..\publish
```
This command will create you an publish folder which contains all necessary binaries.

Within this folder you can call now

```
MergeInterval -s "[25,30] [2,19] [14, 23] [4,8]"
```



