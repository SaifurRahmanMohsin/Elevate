Elevate
=======

A program that simplifies escalation of authority to administrator

Developed using Visual Studio 2010 (x86)
Platform: Windows NT Family
It is a Windows Forms Application without any forms. It takes the first command line argument as the input program to start in elevated mode and can be called directly in an application by a simple system call.
To implement in your application, simple copy the binary from the bin/debug folder into your application folder (or re-compile if you wish to) and then make a system call to this by passing your application filename as an argument. Walla! Your application starts in Administrator mode