using System;
using System.Collections.Generic;
using System.Linq;
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
            Item TestItem = new Item("TestItem"); //(Arrange) Create an Item named “TestItem” and an empty Storage. 
            Storage newStorage = new Storage();

            //(Act) Add the Item to the Storage using the AddItem() method.
            newStorage.AddItem(TestItem);

            //(Assert) Assert that the list has a count of 1 and the first item is the item that was added.
            Assert.Single(newStorage.Contents);

            //(Assert) Assert that the item in Storage.Contents is “TestItem”.
            Assert.Equal(TestItem, newStorage.Contents[0]);
            
            //Osase method
            Assert.Equal("TestItem", newStorage.Contents[0].Name);

        }
        /*
        
        (Arrange) Create an object reference variable to the last item in the Contents list.
        (Act) Run RemoveItem() on the Storage. 
        (Assert) Assert that the count of the Contents has dropped by 1 (is 4)
        (Assert) Assert that the object reference is no longer in the list.
         */
        [Fact]
        public void Remove_Test()
        {
            Storage Storage = new Storage() {  Contents = new List<Item>() { new Item("one"), new Item("two"), new Item("three"), new Item("four"), new Item("five") } };//(Arrange) Create a Storage prepopulated with 5 Items. 

            //(Arrange) Create an object reference variable to the last item in the Contents list.
            Item testItem = new Item("five");

            Storage.RemoveItem(); //(Act) Run RemoveItem() on the Storage. 

            //(Assert) Assert that the count of the Contents has dropped by 1 (is 4)
            Assert.Equal(4, Storage.Contents.Count);

            //(Assert) Assert that the object reference is no longer in the list.
            Assert.DoesNotContain(testItem, Storage.Contents);

        }


    }
}
