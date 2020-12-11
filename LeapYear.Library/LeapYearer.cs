using System;

namespace LeapYear.Library
{
    public class LeapYearer
    {
        public static string getValue(int input)
        {
            if(input % 4 == 0 && input % 100 == 0 && input % 400 != 0)
            {
                return "NOT Leap Year";
            }
            if (input % 4 == 0)
            {
                return "Leap Year";
            }
            if (input % 4 != 0)
            {
                return "NOT Leap Year";
            }
            return input.ToString();
        }
    }
}
