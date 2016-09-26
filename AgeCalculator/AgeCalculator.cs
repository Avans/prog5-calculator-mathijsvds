using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using System.Globalization;

namespace AgeCalculatorNamespace
{
    public class AgeCalculator : IAgeCalculator
    {
        public bool ParseInput(string input, out DateTime result)
        {
            // validate input, both for single and double digits
            if (DateTime.TryParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                return true;
            }
            else if (DateTime.TryParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                return true;
            }
            else return false;
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            int years = DateTime.Today.Year - dateOfBirth.Year;
            // if birthday has not yet passed this year, substract a year
            if (DateTime.Today.DayOfYear < dateOfBirth.DayOfYear)
            {
                years--;
            }

            return years;
        }
    }
}
