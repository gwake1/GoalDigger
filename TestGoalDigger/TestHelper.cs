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
        protected static Window window;
        private static Application application;
        private static WishRepository repo = new WishRepository();
        private static WishContext context;
        private static String applicationPath;

        public static void SetupClass(TestContext _context)
        {
            var applicationDir = _context.DeploymentDirectory;
            applicationPath = Path.Combine(applicationDir, "..\\..\\..\\GoalDigger\\bin\\Debug\\GoalDigger");
        }

        public static void TestPrep()
        {
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
            context = repo.Context();
        }

        public void AndIShouldSeeAnError(string p)
        {
            throw new NotImplementedException();
        }
        public void AndIShouldSeeXEvents(int p)
        {
            Assert.IsNotNull(window);
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("WishList").AndIndex(0);
            ListBox list_box = (ListBox)window.Get(searchCriteria);
            Assert.AreEqual(p, list_box.Items.Count);
        }
        public void AndTheButtonShouldBeEnabled(string p)
        {
            throw new NotImplementedException();
        }
        public void AndTheButtonShouldBeDiasbled(string p)
        {
            throw new NotImplementedException();
        }
        public void AndIShoulSeeAWishFor(string p1, string p2, string p3)
        {
            var e = repo.GetByDate(p2);
            Assert.IsNotNull(window);
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("WishList").AndIndex(0);
            ListBox list_box = (ListBox)window.Get(searchCriteria);
            var item = list_box.Items.Find(i => i.Text == p1);
            Assert.AreEqual(p1, item.Text);
        }
        public void ThenIshouldSeeAWishFor(string p1, string p2, int p3)
        {
            var e = repo.GetByDate(p2);
            Assert.IsNotNull(window);
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("WishList").AndIndex(0);
            ListBox list_box = (ListBox)window.Get(searchCriteria);
            var item = list_box.Items.Find(i => i.Text == p1);
            Assert.AreEqual(p1, item.Text);
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
            WhenIClick(p);
        }
        public void AndIChooseTheWishDate(string p)
        {
            throw new NotImplementedException();
        }
        public void WhenIEnterWishName(string p)
        {
            //TextBox textbox = (TextBox)window.Get(SearchCriteria.ByAutomationId("WishName").AndIndex(0));
            var textbox = window.Get<TextBox>("WishName");
            //textbox.SetValue(p);
        }
        public void AndIEnterWishName(string p)
        {
            WhenIEnterWishName(p);
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
            Button button = (Button)window.Get(SearchCriteria.ByAutomationId(p).AndIndex(0));
            //Button button = window.Get<Button>(SearchCriteria.ByAutomationId(p));
            button.Click();
        }
        public void GivenThereAreNoWishes()
        {
            Assert.AreEqual(0, repo.GetCount());
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
