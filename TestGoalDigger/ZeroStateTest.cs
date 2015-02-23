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
    public class ZeroStateTest : TestHelper
    {
        [ClassInitialize]
        public static void SetupTests(TestContext _context)
        {
            TestHelper.SetupClass(_context);
        }

        [TestInitialize]
        public void SetupTests()
        {
            TestHelper.TestPrep();
        }

        [TestCleanup]
        public void CleanUp()
        {
            TestHelper.CleanThisUp();
        }

        [TestMethod]
        public void TestZeroStateAddButton()
        {
            Button button = window.Get<Button>("AddWish");
            Assert.AreEqual("Add to Wish List", button.Text);
        }
    }
}