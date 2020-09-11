using System;
using Xunit;
using XUnitCumulativePractice;

namespace XUnitCumulativePractice_Tests
{
    public class Program_Tests //Create test cases in Program_Tests.cs that will test each of the requirements of ValidateOneToOneHundredEven().
    {

         [Theory,
                InlineData("one"), //false
                InlineData("101"), //false
                InlineData("3"), //false
                ]
        public void Integer_Test1(string input)
        {
            //Act
            Assert.False(Program.ValidateOneToOneHundredEven(input)); //False
        }

        [Theory,
           InlineData("2", true), //true
           InlineData("-2", false), //false
           InlineData("4", true), //true
        ]
        public void Integer_Test2(string input, bool expectedResult)
        {
            //assertion
            Assert.Equal(expectedResult, Program.ValidateOneToOneHundredEven(input));

        }

        [Theory,
           InlineData("2", true), //true
           InlineData("-1", false), //false
           InlineData("3", false), //false
]
        public void Integer_Test3(string input, bool expectedResult)
        {
            //Act
            Assert.Equal(expectedResult, Program.ValidateOneToOneHundredEven(input)); //False
        }

        [Theory,
           InlineData("2", true), //true
           InlineData("4", true), //true
           InlineData("9", false), //false
        ]
        public void Integer_Test4(string input, bool expectedResult)
        {
            //Act
            Assert.Equal(expectedResult, Program.ValidateOneToOneHundredEven(input)); //False
        }

        [Theory,
           InlineData("2"), //true
           InlineData("4"), //true
           InlineData("6"), //true
        ]
        public void Integer_Test5(string input)
        {
            //Act
            Assert.True(Program.ValidateOneToOneHundredEven(input)); //true
        }
    }
}
