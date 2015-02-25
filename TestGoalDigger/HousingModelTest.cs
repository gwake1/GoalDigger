using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoalDigger.Model;

namespace TestGoalDigger
{
    /// <summary>
    /// Summary description for HousingModel
    /// </summary>
    [TestClass]
    public class HousingModelTest
    {
        [TestMethod]
        public void CreatingAHomeStoresItsProperties()
        {
            Housing home = new Housing("01/01/2015", "Primary Residence", "Expense", 850);
            Assert.AreEqual("01/01/2015", home.Date);
            Assert.AreEqual("Primary Residence", home.Category);
            Assert.AreEqual("Expense", home.Flow);
            Assert.AreEqual(850, home.Amount);
        }
    }
}
