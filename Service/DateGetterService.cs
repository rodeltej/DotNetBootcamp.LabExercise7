using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp.LabExercise7.Service
{
    public class DateGetterService
    {
        public string GetCurrentDate(string pattern)
        {
            DateTime currentDate = DateTime.Now;
            string date = currentDate.ToString(pattern);

            return date;
        }
    }
}
