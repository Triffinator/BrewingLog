using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BrewingLog
{
    [Serializable]
    public class Date
    {
        int day;
        int month;
        int year;

        public Date()
        {}

        public Date(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public Date(Date other)
        {
            day = other.GetDay();
            month = other.GetMonth();
            year = other.GetYear();
        }

        public void SetDay(int d)
        {
            day = d;
        }

        public int GetDay()
        {
            return day;
        }

        public void SetMonth(int m)
        {
            month = m;
        }

        public int GetMonth()
        {
            return month;
        }

        public void SetYear(int y)
        {
            year = y;
        }

        public int GetYear()
        {
            return year;
        }

        /**
         * @param:  Date    other, Date comparative to THIS
         * 
         * @return: bool    true if THIS is equal to other, else false
         */
        public bool Equals(Date other)
        {
            return (day == other.day && month == other.month && year == other.year);  
        }

        /**
         * @param:  Date    other, relative to THIS
         * 
         * @return: bool    true if THIS is LESS THAN or EQUAL TO other, else false
         */
        public bool Prior(Date other)
        {
            if (day <= other.day)
                if (month <= other.month)
                    if (year <= other.year)
                        return true;

            if (year < other.year)
                return true;

            return false;
        }

        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }
    }
}
