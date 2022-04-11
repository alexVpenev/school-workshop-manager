using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManagementApp;

namespace WorkshopManagementUnitTesting
{
    [TestClass]
    public class StudentUnitTesting
    {
        [TestMethod]
        public void GetDisplayInfo_CreateEditAndCheckIfInfoMatchesWithTheGivenInfo_AreEqual()
        {
            //Arrange
            var student = new Student(23, "test");
            //Act
            var result = student.GetDisplayInfo();
            //Assert
            CollectionAssert.AreEqual(new string[] { "23", "test", "Student"}, result);
        }
        [TestMethod]
        public void GetDisplayInfo_CreateAndCheckIfInfoMatchesWithTheGivenInfo_AreNotEqual()
        {
            //Arrange
            var student = new Student(23, "test");
            //Act
            var result = student.GetDisplayInfo();
            //Assert
            CollectionAssert.AreNotEqual(new string[] { "24", "test", "Teacher" }, result);
        }
    }
}
