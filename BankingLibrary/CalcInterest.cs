using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class CalcInterest : ICalcInterest
    {
        public int CalculateSI(int principle, int RateOfInterest, int years)
        {
            int SI = (principle * RateOfInterest * years) / 100;
            return SI;

        }
    }
}
