using System;
using Xunit;
using XUnitCumulativePractice;

namespace XUnitCumulativePractice_Tests
{
    public class Storage_Tests
    {
        /*
		            (Assert) Assert that the list has a count of 1 and the first item is the item that was added.
         */
        [Fact]
        public void Addition_Test() //Test the addition of items (Fact)
        {
            Item newItem = new Item(); //(Arrange) Create an Item and an empty Storage.
            Storage newStorage = new Storage();

            //(Act) Add the Item to the Storage using the AddItem() method.
            newStorage.AddItem(newItem);

            //(Assert) Assert that the list has a count of 1 and the first item is the item that was added.
            Assert.Single(newStorage.Contents);

        }


    }
}
