using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManagementApp;

namespace WorkshopManagementUnitTesting
{
    [TestClass]
    public class TeacherUnitTesting
    {
        [TestMethod]
        public void GetDisplayInfo_CreateAndCheckIfInfoMatchesWithTheGivenInfo_AreEqual()
        {
            //Arrange
            var teacher = new Teacher(23, "test");
            //Act
            var result = teacher.GetDisplayInfo();
            //Assert
            CollectionAssert.AreEqual(new string[] { "23", "test", "Teacher"}, result);
        }
        [TestMethod]
        public void GetDisplayInfo_CreateAndCheckIfInfoMatchesWithTheGivenInfo_AreNotEqual()
        {
            //Arrange
            var teacher = new Teacher(23, "test");
            //Act
            var result = teacher.GetDisplayInfo();
            //Assert
            CollectionAssert.AreNotEqual(new string[] { "24", "test", "Student" }, result);
        }
    }
}
