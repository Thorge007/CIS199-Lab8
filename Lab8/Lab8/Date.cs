using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Date
    {
        private int _month; // 1 - 12
        private int _day; //1 - 31
        private int _year; // >= 0

        // Precondition: None
        // Postcondition: The Date object has been initialized with the specified
        //                month, day, and year
        public Date(int m = 0, int d = 0, int y = 0)
        {
            Month = m;
            Day = d;
            Year = y;
        }

        public int Month
        {
            // Precondition: None
            // Postcondition: The month has been returned
            get
            {
                return _month;
            }
            // Precondition: 1 <= value <= 12
            // Postcondition: Month has been set to a specified value
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
                else
                    _month = 1;
            }
        }

        public int Day
        {
            // Precondition: None
            // Postcondition: The day has been returned
            get
            {
                return _day;
            }
            // Precondition: 1 <= value <= 31
            // Postcondition:Day has been set to a specified value
            set
            {
                if (value >= 1 && value <= 31)
                    _day = value;
                else
                    _day = 1;
            }
        }

        public int Year
        {
            // Precondition: None
            // Postcondition: The year has been returned
            get
            {
                return _year;
            }
            // Precondition: value >= 0
            // Postcondition: Year has been set to a specified value
            set
            {
                if (value >= 0)
                    _year = value;
                else
                    _year = 2019;
            }
        }
        // Precondition: None
        // Postcondition: A string that hodls the format of the Date Form
        public override string ToString()
        {
            string result;

            result = $"{Month:D2}/{Day:D2}/{Year:D4} ";

            return result;
        }
    }
}
