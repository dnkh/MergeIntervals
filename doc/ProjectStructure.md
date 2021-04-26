## Project structure
```
+---doc                             <-- documentation
+---src                             <-- source code folder
|   +---MergeInterval               <-- .net console app  
|   +---MergeInterval.Logic         <-- .net lib which contains the logic
|   +---MergeInterval.Logic.Tests   <-- nunit lib for unit tests
\---test                            <-- folder for test data files
```
### MergeInterval
The MergeInterval project is a typical console app which you use to start the program.
It handles the command line parameter and and arrange the calls in the MergeInterval.Logic library

### MergeInterval.Logic
This library contains the logic and the knowlege. It's in a separat library so it can be used in other programs and can be easily tested. 

### MergeInterval.Logic.Tests
MergeInterval.Logic.Tests contains the unit tests. 

**Because the task was to write a MERGE function there are only unit tests for the *IntervalMerger and Interval* class** 
