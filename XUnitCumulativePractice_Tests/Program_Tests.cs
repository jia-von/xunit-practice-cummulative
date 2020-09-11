using System;
using Xunit;
using XUnitCumulativePractice;

namespace XUnitCumulativePractice_Tests
{
    public class Program_Tests //Create test cases in Program_Tests.cs that will test each of the requirements of ValidateOneToOneHundredEven().
    {

         [Theory,
                InlineData("one"), //false
                InlineData("-1"), //false
                InlineData("1"), //false
                ]
        public void Integer_Test1(string input)
        {
            //Act
            Assert.False(Program.ValidateOneToOneHundredEven(input)); //False
        }

        [Theory,
           InlineData("1"), //true
           InlineData("-1"), //false
           InlineData("2"), //true
        ]
        public void Integer_Test2(string input)
        {
            //Act
            Assert.False(Program.ValidateOneToOneHundredEven(input)); //False
        }

        [Theory,
           InlineData("1"), //true
           InlineData("-1"), //false
           InlineData("3"), //false
]
        public void Integer_Test3(string input)
        {
            //Act
            Assert.False(Program.ValidateOneToOneHundredEven(input)); //False
        }

        [Theory,
           InlineData("1"), //true
           InlineData("-1"), //true
           InlineData("3"), //false
        ]
        public void Integer_Test4(string input)
        {
            //Act
            Assert.False(Program.ValidateOneToOneHundredEven(input)); //False
        }

        [Theory,
           InlineData("2"), //true
           InlineData("4"), //true
           InlineData("6"), //true
        ]
        public void Integer_Test5(string input)
        {
            //Act
            Assert.False(Program.ValidateOneToOneHundredEven(input)); //true
        }
    }
}
