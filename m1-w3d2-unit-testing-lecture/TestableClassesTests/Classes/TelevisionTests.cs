using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;

namespace TestableClassesTests.Classes
{
    [TestClass]
    public class TelevisionTests
    {
        [TestMethod]
        public void DefaultTelevisionTest()
        {
            //Arrange your variables
            Television tv;

            //Act by performing the action you want to test
            tv = new Television();

            //Assert by validating your expected outputs
            Assert.IsFalse(tv.IsOn);
            Assert.AreEqual(3, tv.CurrentChannel);
            Assert.AreEqual(2, tv.CurrentVolume);
        }


        [TestMethod]
        public void DoesATvTurnOnWhenITurnItOn()
        {
            //Arrange
            Television tv = new Television();

            //Act
            tv.TurnOn();

            //Assert
            //Assert.IsFalse(tv.IsOn);
            Assert.AreEqual(true, tv.IsOn);
            Assert.AreEqual(3, tv.CurrentChannel);
            Assert.AreEqual(2, tv.CurrentVolume);
        }

        [TestMethod]
        public void WhenIChangeChannelAndTvIsOnThenChannelChanges()
        {
            //Arrange
            Television tv = new Television();
            tv.TurnOn();

            //Act
            tv.ChangeChannel(5);

            //Assert
            Assert.AreEqual(5, tv.CurrentChannel);            
        }

        [TestMethod]
        public void WhenIChannelUpFrom18ItShouldBe3()
        {
            //Arrange
            Television tv = new Television();
            tv.TurnOn();
            tv.ChangeChannel(18);

            //Act
            tv.ChannelUp();

            //Assert
            Assert.AreEqual(3, tv.CurrentChannel);
        }
    }
}
