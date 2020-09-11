using System;
using Xunit;
using XUnitCumulativePractice;

namespace XUnitCumulativePractice_Tests
{
    public class Program_Tests //Create test cases in Program_Tests.cs that will test each of the requirements of ValidateOneToOneHundredEven().
    {
        [Theory,
            InlineData("-1", false),
            InlineData("0", false),
            InlineData("1", false),
            InlineData("101", false),
            InlineData("100", true),
            ]
        public void Validation_Test(string input, bool expectedResult)
        {
            //Assert
            Assert.Equal(expectedResult, Program.ValidateOneToOneHundredEven(input));
        }

         [Theory,
                InlineData("-1", true),
                InlineData("0", true),
                InlineData("1", true),
                InlineData("100", true),
                InlineData("one", false),
                ]
        public void Integer_Test(string input, bool expectedResult)
        {
            //Arrange

           
            //Act
            Assert.Equal(expectedResult, Program.ValidateOneToOneHundredEven(input));
        }
    }
}
