using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitCumulativePractice //Create a class called “Storage” with the following properties and methods:
{
    public class Storage
    {
        public List<Item> Contents { get; set; }//“Contents” (list of Items)

        public void AddItem(Item item)//AddItem() will accept an item and add it to the “Contents” list.
        {
            Contents.Add(item);
        }

        public void RemoveItem()
        {
            Contents.RemoveAt(Contents.Count - 1); //James Grieve, 9-Sep-2020 
        }

        public Storage()
        {
            Contents = new List<Item>();
        }
    }
}
