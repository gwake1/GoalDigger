﻿﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using System.Reflection;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;
using System.Windows.Automation;
using TestStack.White.UIItems;
using GoalDigger;
using GoalDigger.Model;
using GoalDigger.Repository;

namespace TestGoalDigger
{
    public class TestHelper
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;
        private static WishRepository repo = new WishRepository();
        private static WishContext context;

        public static void Setup(TestContext _context)
        {
            test_context = _context;

            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\GoalDigger\\bin\\Debug\\GoalDigger");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
            //repo = new EventRepository();
            context = repo.Context();

        }

        public void AndIShouldSeeAnError(string p)
        {
            throw new NotImplementedException();
        }
        public void AndIShouldSeeXEvents(int p)
        {
            Assert.IsNotNull(window);
            ListBox wishitems = window.Get<ListBox>("WishList");
            Assert.AreEqual(p, wishitems.Items.Count);
        }
        public void AndTheButtonShouldBeEnabled(string p)
        {
            throw new NotImplementedException();
        }
        public void AndTheButtonShouldBeDiasbled(string p)
        {
            throw new NotImplementedException();
        }
        public void AndIShoulSeeAWishFor(string p1, string p2, int p3)
        {
            throw new NotImplementedException();
        }
        public void ThenIshouldSeeAWishFor(string p1, string p2, int p3)
        {
            throw new NotImplementedException();
        }
        public void AndIshouldSeeAWishFor(string p1, string p2, int p3)
        {
            throw new NotImplementedException();
        }
        public void ThenIShouldSeeTheWishForm()
        {
            throw new NotImplementedException();
        }
        public void ThenIShouldNotSeeTheWishForm()
        {
            throw new NotImplementedException();
        }
        public void AndIClick(string p)
        {
            throw new NotImplementedException();
        }
        public void AndIChooseTheWishDate(string p)
        {
            throw new NotImplementedException();
        }
        public void AndIEnterWishName(string p)
        {
            throw new NotImplementedException();
        }
        public void WhenIEnterWishName(string p)
        {
            throw new NotImplementedException();
        }
        public void AndIEnterWishDate(string p)
        {
            throw new NotImplementedException();
        }
        public void AndTheWishDateShouldBe30DaysFromNow()
        {
            throw new NotImplementedException();
        }
        public void WhenIClick(string p)
        {
            throw new NotImplementedException();
        }
        public void GivenThereAreNoWishes()
        {
            throw new NotImplementedException();
        }
        public void GivenTheseWishes(params Wish[] wishes)
        {
            foreach (Wish wish in wishes)
            {
                //add wish to wishes
            }
        }
        public void AndIShouldSeeAnErrorMessage(string p1)
        {
            throw new NotImplementedException();
        }
        public void AndIChooseTheWishPrice(int p1)
        {
            throw new NotImplementedException();
        }
        public static void CleanThisUp()
        {
            window.Close();
            repo.Clear();
            application.Close();
        }
    }
}
