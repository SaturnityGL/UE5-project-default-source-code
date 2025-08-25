# UE5-project-default-source-code
Ue5 Users\XXXXX\Documents\Unreal Projects\MyProject\Source and modules missing
I am writing this and attaching it to a thread to hope that someday, someone else with a similar problem will find it as a fix. I checked every forum and tried everything, nothing I found was anywhere close to what I ACTUALLY had to do to fix it. Nothing worked, so cue like 8 hours straight of trial and error and really digging into UE5 files and following every error as far as I can.

I made a project in UE5 and made an actor using C++, this caused a whole bunch of issues. Edited the default .h and .cpp file in the source, renamed them, never recompiled, and then later on while trying to fix it, straight up deleting them.

This led to everytime I opened my fresh SLN to try and recompile, I would get the errors in VS2022, on top of causing "Developer_Tools" configuration to not appear, only "BuiltWithUnrealBuildTool" the two errors were;Projects\\MyProject\\Intermediate\\ProjectFiles\\UE5.vcxproj : warning : The build tools for Visual Studio 2022 (v143) cannot be found. Install Visual Studio 2022 (v143) to build using the Visual Studio 2022 (v143) build tools.   

Documents\\Unreal Projects\\MyProject\\Intermediate\\ProjectFiles\\UE5.vcxproj : warning : Platform 'Win64' referenced in the project file 'UE5' cannot be found. 

I will be adding a text doc that explains what I did to finally start solving. Hope it helps somebody, because the last two days has been purely awful. 

Also, this was in relation to a bunch of modules not working.

Going to add tags/labels down here to help reach




Modules, modules missing, VS2022, Visual Studio 2022, Visual Studio, Recreate modules, Can't recompile while engine running, Use IDE, Solution, .sln, can't compile .sln, development editor not showing up
