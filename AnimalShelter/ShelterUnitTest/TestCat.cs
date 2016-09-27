using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace ShelterUnitTest
{
    [TestClass]
    public class TestCat
    {
        private Cat testCat;
        [TestMethod]
        public void TestInitialise()
        {            
           this.testCat = new Cat("Mittens", DateTime.Today);

            Assert.AreEqual("Mittens", testCat.Name);
            Assert.AreEqual(DateTime.Today, testCat.Birthdate);
            Assert.AreEqual("Henk", testCat.Owner.Name);
        }

        public void TestAddHabit()
        {
            Assert.IsNull(testCat.Habits);

            testCat.AddHabit("Kut kat");

            Assert.IsNotNull(testCat.Habits);
        }

        public void TestRemoveHabit()
        {
            Assert.IsNotNull(testCat.Habits);

            testCat.RemoveHabit("Kut kat");

            Assert.IsNull(testCat.Habits);
        }
    }
}
