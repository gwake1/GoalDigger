using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoalDigger.Model;

namespace TestGoalDigger
{
    [TestClass]
    public class ViewingWishesTest: TestHelper
    {
        // As a user
        // In order to have hope in my life
        // I want to see wishes that i am saving for

        [TestMethod]
        public void ScenarioViewingCountdownsWhenThereAreEvents()
        {
            GivenTheseEvents(
                new Wish("Surfboard", "02/15/2015", 80),
                new Wish("Christmas", "12/25/14", 100)
                );
            AndIShouldSeeXEvents(2);
            AndIShoulSeeAWishFor("Valentine's Day", "02/14/15", 80);
            AndIShoulSeeAWishFor("Christmas", "12/25/14", 100);
            AndTheButtonShouldBeEnabled("Add Wish");
        }
    }
}
