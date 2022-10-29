# Overview
I have created this simple API to learn about API controllers and how to build them effectivley.

This C# progam is written to create a list of type Business. The Business class has three properties. These properties are Id, BusinessName, and Revenue. I chose C# and .NET for this project because I am very comfortable with C# and ASP.NET core offers a easy to use API template to work with. They also offer preconfigured Swagger documentation support for easy testing.


| Property | Type |
| --- | ----------- |
| Id | int |
| BusinessName | string |
| Revenue | float |


My purpose for creating this software is to begin to learn how to create and work with API's. I am beginning to work on a project that tracks revenue and sales for a business and then measures those against goals that have been previously set by the owner or manager of the business.

[Demo Video](https://youtu.be/fAeBTGD0BRw)

# Development Environment

For this project I developed it in Rider by JetBrains, Ride is a C# and .NET IDE comparable to Visual Studio. I also use a Macbook Pro with an M1 Pro chip.

This program is written in C#, C# is an object oriented programming language that is ran on the .NET framework by Microsoft. If you are a Java or C++
developer, C# is very similar and you can pick it up very easily.

# Useful Websites

* [C# and .NET docs](https://learn.microsoft.com/en-us/dotnet/csharp/)
* [C# and ASP.NET webAPI tutorial](https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/1-introduction)

# Run the Program

  * To run the progam you will need to have C# and .NET 6.0 installed on your local machine.
  
  ## Instructions
    1. Install C# and .NET 6.0
    2. Clone this repository
    3. Make sure you have a mySQL server running on your local machine.
    4. open a new terminal and type 'dotnet build' 
    5. Once you recieve a 'build succesecul' notification, type 'dotnet run'
    6. The program will open your default browser with a Swagger page
