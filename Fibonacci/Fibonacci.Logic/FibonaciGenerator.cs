using System.Collections.Generic;
using System.Linq;

namespace Fibonacci.Logic
{
    public class FibonaciGenerator
    {
        public List<int> fibonacci(int n)
        {
            List<int> results = new List<int> { 0 };

            //Note: We need this line because the second element in the sequence
            //      still needs to increment, and there'd be nothing to add to.
            if (n > 1)
                results.Add(1);

            //Note: We need this line because the third element in the sequence
            //      still needs to increment.
            if (n>2)
                results.Add(2);

            //This is to get the list to the correct length in the number of you want.
            while (n > results.Count)
            {
                //Generate the new Number
                int newNumber = results.OrderByDescending(x=>x).Take(2).Sum();
                results.Add(newNumber);
            }

            return results;
        }
    }
}
