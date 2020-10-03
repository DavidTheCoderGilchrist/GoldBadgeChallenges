using System;
using ChallengeFour_Repository;
using ChallengeFour_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeFour_Tests
{
    [TestClass]
    public class ChallengeFourTests
    {
        private OutingRepository outingTest = new OutingRepository();

        [TestInitialize]
        private void SeedOutingList()
        {
            OutingContent outingOne = new OutingContent(EventType.Bowling, 20, new DateTime(2020, 8, 8), 20.00m);
            OutingContent outingTwo = new OutingContent(EventType.AmusementPark, 50, new DateTime(2020, 10, 1), 50.00m);
            OutingContent outingThree = new OutingContent(EventType.Concert, 30, new DateTime(2020, 7, 15), 30.00m);

            outingTest.AddOuting(outingOne);
            outingTest.AddOuting(outingTwo);
            outingTest.AddOuting(outingThree);
        }

        [TestMethod]
        public void DisplayAllOutingTest()
        {
            outingTest.DispalyAllOutings(); 
        }

        public void AddOutingTest()
        {
            //Arrange
            OutingContent outingFour = new OutingContent(EventType.Golf,10,new DateTime(2020,8,20),45.00m);

            //Act
            outingTest.AddOuting(outingFour);
            int actual = outingTest.GetOutingList().Count;

            //Assert
            Assert.AreEqual(4, actual);
        }



    }
}
