# C# compilation program

To compile a main class in C#, you need to use a compiler tool such as **csc.exe** (the C# compiler) or **dotnet build** (the .NET CLI tool). These tools will take your source code files and produce an executable file (.exe) or a library file (.dll) that can run on the .NET runtime.

If you have only one class that has a Main method, you don't need to specify anything else when compiling. For example, if you have a file named Program.cs that contains your main class, you can use these commands:

```bash
# Using csc.exe
csc Program.cs

# Using dotnet build
dotnet new console -o MyProgram # Create a new console project
dotnet build MyProgram # Build the project
```

If you have more than one class that has a Main method, you must compile your program with the **StartupObject** compiler option to specify which Main method to use as the entry point¹³. For example, if you have two classes named Program and Form1 that both have a Main method, and you want to use Form1 as the entry point, you can use these commands:

```bash
# Using csc.exe
csc /main:Form1 Program.cs Form1.cs

# Using dotnet build
dotnet new console -o MyProgram # Create a new console project
dotnet build /p:StartupObject=Form1 MyProgram # Build the project with StartupObject option
```