using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopManagementApp;

namespace WorkshopManagementUnitTesting
{
    [TestClass]
    public class WorkshopManagementTests
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    naming name of method_Scenarii_ExpectedBehavior()

        //    Arrange - object creation

        //    Act - call method(s)
        //    var result = true

        //    Assert -
        //    Assert.IsTrue(result)

        //}
        [TestMethod]
        public void CheckIfWksHasStarted_WorkshopIsNotStarted_ReturnsFalse()
        {
            //Arrange
            var wk = new WorkshopManagement();
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateOnlineWorkshop("test", "testing", 23);
            //Act
            var result = wk.CheckIfWksHasStarted(1000);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckIfWksHasStarted_WorkshopIsStarted_ReturnsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateOnlineWorkshop("test", "testing", 23);
            wk.StartWorkshop(1000);
            bool result = wk.CheckIfWksHasStarted(1000);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfWorkshopIsOnline_WorkshopIsOnline_ReturnsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateOnlineWorkshop("test", "testing", 23);
            bool result = wk.CheckIfWorkshopIsOnline(1000);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfWorkshopIsOnline_WorkshopIsInBuilding_ReturnsFalse()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateInBuildingWorkshop("test", "testing", 23, 30, "test", 5);
            bool result = wk.CheckIfWorkshopIsOnline(1000);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckIfAPersonIsAStudent_PersonIsStudent_ReturnsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateStudent(23, "testStudent");
            bool result = wk.CheckIfPersonIsAStudent(23);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfAPersonIsAStudent_PersonIsTeacher_ReturnsFalse()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            bool result = wk.CheckIfPersonIsAStudent(23);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GetPersonInfo_CheckIfCreatedTeacherMatchesGivenInfo_AreEqual()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            string[] result = wk.GetPersonInfo(23);
            string[] expected = { 23.ToString(), "testTeacher" };
            //Assert
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetAllPersonWorkshops_GetAllClassesATeacherTeachesIn_AreEqual()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateOnlineWorkshop("test", "testing", 23);
            List<string[]> result = wk.GetAllPersonsWorkshops(23);
            List<string[]> expected = new List<string[]>();
            string[] vs = result[0];
            expected.Add(wk.GetWorkshopDisplayInfoElementsById(Convert.ToInt32(vs[0])));
            //Assert
            CollectionAssert.AreEqual(expected[0], result[0]);
        }
        [TestMethod]
        public void EnrollStudentInAWks_EnrollStudentInWks_AreEqual()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateStudent(24, "testStudent");
            wk.CreateOnlineWorkshop("test", "testing", 23);
            wk.EnrollStudentInAWks(1000, 24);
            List<string[]> result = wk.GetAllPersonsWorkshops(23);
            List<string[]> expected = new List<string[]>();
            string[] vs = result[0];
            expected.Add(wk.GetWorkshopDisplayInfoElementsById(Convert.ToInt32(vs[0])));
            //Assert
            CollectionAssert.AreEqual(expected[0], result[0]);
        }
        [TestMethod]
        public void CheckIfWksHasEnoughCapacity_CheckIfStudentCanBeEnrolled_IsFalse()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateInBuildingWorkshop("test", "testing", 23, 30, "test", 5);
            bool result = wk.CheckIfWksHasEnoughCapacity(1000);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckIfWksHasEnoughCapacity_CheckIfStudentCannotBeEnrolled_IsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateStudent(24, "testStudent");
            wk.CreateInBuildingWorkshop("test", "testing", 23, 1, "test", 5);
                wk.EnrollStudentInAWks(1000, 24);
            bool result = wk.CheckIfWksHasEnoughCapacity(1000);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfCapacityCanBeEdited_ChangeToLessCapacityWhenMoreStudentsAreAlreadyEnrolled_IsFalse()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateStudent(24, "testStudent");
            wk.CreateInBuildingWorkshop("test", "testing", 23, 2, "test", 5);
            wk.EnrollStudentInAWks(1000, 24);
            wk.EnrollStudentInAWks(1000, 24);
            bool result = wk.CheckIfCapacityCanBeEdited(1000, 1);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckIfCapacityCanBeEdited_ChangeToLessCapacityWhenMoreStudentsAreAlreadyEnrolled_IsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateInBuildingWorkshop("test", "testing", 23, 2, "test", 5);
            bool result = wk.CheckIfCapacityCanBeEdited(1000, 1);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfPcnExists_CrearteATeacherAndCheckIfPcnExists_IsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            bool result = wk.CheckIfPcnExists(23);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfPcnExists_CrearteAStudentAndCheckIfPcnExists_IsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateStudent(23, "testTeacher");
            bool result = wk.CheckIfPcnExists(23);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfPcnExists_CheckIfANonExistingPcnExists_IsFalse()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            bool result = wk.CheckIfPcnExists(23);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckIfAStudentIsAlreadyEnrolled_EnrollAStudentAndCheckIfHeIsEnrolled_IsFalse()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateStudent(24, "testStudent");
            wk.CreateInBuildingWorkshop("test", "testing", 23, 2, "test", 5);
            wk.EnrollStudentInAWks(1000, 24);
            bool result = wk.CheckIfStudentIsAlreadyEnrolled(1000, 24);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckIfAStudentIsAlreadyEnrolled_CheckIfAStudentWithAFalsePcnIsAlreadyEnrolled_IsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateStudent(24, "testStudent");
            wk.CreateInBuildingWorkshop("test", "testing", 23, 2, "test", 5);
            bool result = wk.CheckIfStudentIsAlreadyEnrolled(1000, 24);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfAStudentIsAlreadyEnrolled_CheckIfATeacherIsEnrolledAsAStudent_IsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateTeacher(23, "testTeacher");
            wk.CreateInBuildingWorkshop("test", "testing", 23, 2, "test", 5);
            bool result = wk.CheckIfStudentIsAlreadyEnrolled(1000, 23);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfPcnCanBeEdited_Create2StudentsAndCheckIfYouCanCahngeToTheSamePcnAsSelected_IsFalse()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateStudent(23, "testTeacher");
            wk.CreateStudent(24, "testStudent");
            bool result = wk.CheckIfPcnCanBeEdited(24, 23);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void CheckIfPcnCanBeEdited_CreateAStudentAndDoNotChangeHisPcnWhileEditinTheRestOfTheInfo_IsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateStudent(23, "testTeacher");
            bool result = wk.CheckIfPcnCanBeEdited(23, 23);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CheckIfPcnCanBeEdited_CreateAndCheckIfAStudentCanChangeHisPcnWithANonExistingOne_IsTrue()
        {
            //Arrange
            var wk = new WorkshopManagement();
            //Act
            wk.CreateStudent(23, "testTeacher");
            bool result = wk.CheckIfPcnCanBeEdited(24, 23);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
