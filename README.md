# About this repository
this is a repository with test tasks from amc bridge on the [amc bridge tutor](https://tutor.amcbridge.com/) platform

# Limitations
The languages supported are C#.

Supported compilers are:

- C#: Language version: 5; Target framework: 4.5

Each solution must be a single file containing a console application and meeting these requirements:

- The file extension corresponds to the language used `.cs` for C#.
- For the solutions in Java, the file name and the main class name is the same as the project code. Note, that the project code of a task might differ from its name.

Inputs must be read from the standard input stream. Outputs must be written to the standard output stream.

An output must contain only the information required in a task. Extra characters, including extra spaces or line breaks at the end of a file/line, will lead to the wrong result.

Unless a task description specifies other:

- All input and output integer numbers are guaranteed to fit into four-bytes signed integer type.
- All input and output real numbers are guaranteed to fit into eight-bytes double-precision floating-point type.
- Real non-integer numbers must be written to the output stream with 8-digit decimal precision. Two real numbers A and B are equal if |A-B|<`1e-8`. For example, both `3.14159265359` and `3.14159265` are correct values of PI; both `3.14` and `3.1415926` are incorrect values of PI.
- The termination number is -1. It does not belong to any pieces of data, its only purpose is to inform about the end of a piece of data.
- Input and output numbers must be separated by space, including the termination number.
