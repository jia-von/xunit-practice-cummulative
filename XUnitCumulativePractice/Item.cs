using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitCumulativePractice
{
    public class Item //Create a class called “Item” with the following properties:
    {
        public string Name { get; set; } //“Name” (string).

        //A default and greedy constructor.
        public Item()
        {
            Name = "Default Name";
        }

        public Item(string name)
        {
            Name = name;
        }
    }
}
