using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManagementApp;

namespace WorkshopManagementUnitTesting
{
    [TestClass]
    public class InBuildingWorkshopUnitTesting
    {
        [TestMethod]
        public void GetDisplayInfo_CreateAndCheckIfInfoMatchesWithTheGivenInfo_AreEqual()
        {
            //Arrange
            var wks = new InBuilding(1000, "test", "test", new Teacher(23, "test"), 23, "test", 15);
            //Act
            var result = wks.GetDisplayInfo();
            //Assert
            CollectionAssert.AreEqual(new string[] { "1000", "test", "In Building", "Not Started" }, result);
        }
        [TestMethod]
        public void GetDisplayInfo_CreateAndCheckIfInfoMatchesWithTheGivenInfo_AreNotEqual()
        {
            //Arrange
            var wks = new InBuilding(1000, "test", "test", new Teacher(23, "test"), 23, "test", 15);
            //Act
            var result = wks.GetDisplayInfo();
            //Assert
            CollectionAssert.AreNotEqual(new string[] { "24", "test", "Student" }, result);
        }
    }
}
