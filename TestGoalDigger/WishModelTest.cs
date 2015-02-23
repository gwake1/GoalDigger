using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoalDigger.Model;

namespace TestGoalDigger
{
    [TestClass]
    public class WishModelTest
    {
        //[TestMethod]
        //public void CreatingAWishStoresItInWishes()
        //{
        //    Wish beyonce = new Wish("QueenB", "02/14/2015", 1000000);
        //    //CollectionAssert.Contains(Wish.Wishes, beyonce);
        //}


        [TestMethod]
        public void CreatingAWishStoresItsProperties()
        {
            Wish item = new Wish("SurfBoard", "02/14/2015", 80);
            Assert.AreEqual("SurfBoard", item.Name);
            Assert.AreEqual("02/14/2015", item.Date);
            Assert.AreEqual(80, item.Price);
        }
    }
}
