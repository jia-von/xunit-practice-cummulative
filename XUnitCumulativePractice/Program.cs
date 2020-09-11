using System;

namespace XUnitCumulativePractice
{
    public class Program //(ensure your “Program” class is public).
    {
        public static void Main(string[] args)
        {
           
        }                                                                 
        public static bool ValidateOneToOneHundredEven(string input)//Create a method in XUnitCumulativePractice.Program.cs called ValidateOneToOneHundredEven() that will accept a string (“1” or “20” etc.)  as a parameter. Validate that the string:
        {
            input.GetType();
                if (Int32.Parse(input).GetType() == typeof(int))//Is an integer (numeric, will safely parse to int).
            {
                    int numInput = Int32.Parse(input); 

                    if (numInput >= 1 && numInput <= 100 && numInput % 2 == 0)//Is between 1 and 100. Is even.
                    {
                        return true; //If it is, return true. Otherwise return false.
                    }
                }
         return false;
        }
    }
}
