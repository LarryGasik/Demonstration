using System.Linq;

namespace IntegerSumming
{
    ////Question 1
    //1) Compiles cleanly without errors
    //2) Takes an array of objects as its only argument
    //3) Returns the sum of any of the array elements that are ints (other data types such as strings, floats, longs, and bytes do not count)
    //4) It must never throw an error for any given input
    
    /// <summary>
    /// Functions for Integers
    /// </summary>
    public static class IntegerCalculator
    {
        /// <summary>
        /// This method will sum all integers in an array of objects, but not include the
        /// values of non-integer types.
        /// </summary>
        /// <param name="inputValue">Array of objects to be summed</param>
        /// <returns>Sum of any integers in inputValue</returns>
        public static int SumOfIntegers(object[] inputValue)
        {
            return inputValue.OfType<int>().Sum();
        }
    }
}
