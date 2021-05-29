using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Greyhound_Racing_Game;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        Punter newPunter = new Parminder();

        [TestMethod]
        public void TestChecking_starting_amount() // Tests to make sure the Instantiation has worked by making sure the cash amounts are correct
        {
            int ExpectedCash = 50;
            int ActualCash = newPunter.Cash;
            Assert.AreEqual(ExpectedCash, ActualCash);
        }
    }
}
