﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;

namespace TestGoalDigger
{
    [TestClass]
    public class ZeroStateTest
    {

        private static TestContext test_context;
        private static Window window;
        private static Application application;

        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\GoalDigger\\bin\\Debug\\GoalDigger");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
        }

        [TestMethod]
        public void TestZeroStateAddWishButton()
        {
            Button button = window.Get<Button>("AddWish");
            Assert.AreEqual("Add to Wish List", button.Text);
        }

        [TestMethod]
        public void TestZeroStateDefaultWishList()
        {
            ListBox wishlist = window.Get<ListBox>("WishList");
            Assert.AreEqual(1, wishlist.Items.Count);
            Assert.AreEqual("SurfBoard", wishlist.Items[0].Text);
        }

        [ClassCleanup]
        public static void CleanThisUp()
        {
            window.Close();
            application.Close();
        }
    }
}