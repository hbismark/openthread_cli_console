# openthread_cli_console
A GUI for the OpenThread CLI

This software is written in C# under Micrsosoft Visual Studio 2017 on Windows 10 to make my live easier when playing around with OpenThread.
It is provided as it is without any guarantees of proper function on any target system or Windows version. It contains no executables but the solution. You have to install Microsoft visual Studio 2017, open the solution and compile it on your own computer.
It has for sure much to improve, but it is not meant to be perfect, just a quick tool for the purpose.

Possible improvments would be a drop down list with all possible commands.

Short instructions:

1. Choose COM port and press open
2. Press router table (this fills the Nodes drop-down list with the RLOC16 values of all routers)

If you want to get also the childs in the list, press Sequence

In the Command test field you can type anny command with parameters and press ENTER to send this to the node as on the command line.

diag get sends the networkdiagnostic get command to the choosen node with the TLV numbers listed with space in Parameter.

The Clear button clears the output window.

If you select/mark one line in the output window you can copy that line to the clipboard.
