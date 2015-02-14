using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace TestGoalDigger
{
    [TestClass]
    public class AddWishTest: TestHelper
    {
        // As a user
        // In order to see how much I must save for a wish item
        // I want to create a new wish
        // * Click "Add Wish" to get the add new wish form
        // * Wish name must contain at least one character
        // * Wish date can be in the past or future, but is required
        // * Wish date is auto-populated to 30 days from now
        // * Click "Add Wish" to add the wish
        // * The wish shows up in the main wish list and the form goes away
        // * Click "x" to close the form

        [TestMethod]
        public void ScenarioHappyPathEventCreation()
        {
            GivenThereAreNoWishes();
            ThenIshouldSeeAWishFor("SurfBoard", "02/14/15", 80);
            WhenIClick("Add Wish");
            ThenIShouldSeeTheWishForm();
            AndTheWishDateShouldBe30DaysFromNow();
            AndTheButtonShouldBeDiasbled("Add Wish");
            AndIEnterWishName("SurfBoard");
            AndIChooseTheWishDate("02/14/2015");
            AndIClick("Add Wish");
            ThenIShouldNotSeeTheWishForm();
            AndIShouldSeeXEvents(1);
            AndIshouldSeeAWishFor("SurfBoard", "02/14/2015", 80);
            AndTheButtonShouldBeEnabled("Add Wish");
        }

        [TestMethod]
        public void ScenarioDataValidationForWishCreation()
        {
            GivenThereAreNoWishes();
            WhenIClick("Add Wish");
            ThenIShouldSeeTheWishForm();
            AndIShouldSeeAnErrorMessage("Event title must be filled in.");
            WhenIEnterWishName("SurfBoard");
            AndIChooseTheWishDate("02/14/2015");
            AndIChooseTheWishPrice(80);
            AndIClick("Add Wish");
            ThenIShouldNotSeeTheWishForm();
            AndIShouldSeeXEvents(1);
            AndIshouldSeeAWishFor("Valentine's", "02/14/15", 80);
        }

        [TestMethod]
        public void ScenarioCancelingOutOfEventCreation()
        {
            GivenThereAreNoWishes();
            WhenIClick("Add Wish");
            WhenIEnterWishName("SurfBoard");
            AndIEnterWishDate("02/14/2015");
            AndIClick("Cancel");
            ThenIShouldNotSeeTheWishForm();
            AndIShouldSeeXEvents(0);
            WhenIClick("Add Wish");
            ThenIShouldSeeTheWishForm();
            AndTheWishDateShouldBe30DaysFromNow();
        }
    }
}
