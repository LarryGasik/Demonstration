using System;

namespace SomeService
{
    public static class TimeService
    {
        public static bool IsSecondEven(DateTime candidate)
        {
            return candidate.Second % 2 == 0;
        }
    }
}