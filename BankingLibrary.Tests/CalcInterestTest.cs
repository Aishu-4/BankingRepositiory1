using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankingLibrary.Tests
{
    [TestClass]
    public class CalcInterestTests
    {
        [TestMethod]
        public void CalcSI_rets_SI()
        {
            int expecresult = 1000;
            ICalcInterest calc = new CalcInterest();
            int actualresult = calc.CalculateSI(10000, 1, 10);
            Assert.AreEqual(expecresult, actualresult);
        }
    }
}
