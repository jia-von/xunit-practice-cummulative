# C# XUnit Practice within Microsoft.NETCore.App

The goal of this assignment is designed to help me familiarized with the fundementals of XUnit testing in an object-oriented implmentation.
 

## Installation

Packages used within .NET Core:
- Microsoft.NET.Test.Sdk
- xunit

```bash

git clone https://github.com/jia-von/xunit-practice-cummulative.git
cd xunit-practice-cumulative-jia-von
cd XUnitCumulativePractice
start devenv XUnitCumulativePractice.sln

```

## Approach

 - A solution and console application was created with a name `XUnitCumulativePractice.sln`.
 - A new XUnit Test project (.NET Core) was created with solution name `XUnitCumulativePractice_Tests.sln`.

 - A program written named `ValidateOneToOneHundredEven()` method.
   - This method that will accept a string (“1” or “20” etc.)  as a parameter.
	- Test casses was created to test tis method and to validate string as integers. 

- Two classes was created, `Item.cs` and `Storage.cs`.
  - `Item.cs` have a string property.
  - `Storage.cs` have list properties and methods, `AddItem()` and `RemoveItem()`. 

- Several tests were written for:
  - Addition of created ***Item*** to a list in ***Storage***.
  - Removal of items from ***Storage***.

### Example Screenshot of the Test Explorer
 		
![Example Screenshot of XUnit testing](/References/Program_Tests.PNG)
