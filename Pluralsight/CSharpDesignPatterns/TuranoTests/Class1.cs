namespace TuranoTests
{
    public class Class1()
    {
        public decimal BusinessMethod(bool isTuesday, string accountCode, string role, bool isLucky, string state)
        {
            if (role == "admin" || (role == "student" && isTuesday))
                return 100;
            if (isLucky && (isTuesday || state == "IL"))
            {
                return 2;
            }
            return 0;
        }
    }

    public class someServiceObject
    {
        public bool isConfirmed { get; set; }
        Guid id { get; set; }
    }
}
