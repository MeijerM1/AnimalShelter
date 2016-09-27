using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace ShelterUnitTest
{
    [TestClass]
    public class TestDog
    {
        private Dog testDog;

        [TestMethod]
        public void TestInitialise()
        {
            this.testDog = new Dog("Trigger", DateTime.Today);

            Assert.AreEqual("Trigger", testDog.Name);
            Assert.AreEqual(DateTime.Today, testDog.Birthdate);
            Assert.AreEqual("Henk", testDog.Owner.Name);
        }

        public void TestAddWalkDate()
        {
            testDog.ChangeDateOfLastWalk(DateTime.Today);

            Assert.AreEqual(testDog.TimeOfLastWalk, DateTime.Today);
        }
    }
}
