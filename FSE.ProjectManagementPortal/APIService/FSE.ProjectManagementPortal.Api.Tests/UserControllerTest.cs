using FSE.ProjectManagementPortal.Api.Controllers;
using FSE.ProjectManagementPortal.DataContract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace FSE.ProjectManagementPortal.Api.Tests
{
    [TestClass]
    public class UserControllerTest
    {
        UserController userController;

        /// <summary>
        /// Get the User details
        /// </summary>
        [TestMethod]
        public void GetAllUserDetails_ShouldNotNull()
        {
            //Arrange
            userController = new UserController();

            //Act
            var userList = userController.GetAllUserDetails();

            //Assert
            Assert.IsNotNull(userList);
            Assert.IsTrue(userList.Count > 0);
        }

        /// <summary>
        /// Add User and get success
        /// </summary>
        [TestMethod]
        public void AddUserDetails_Successfully()
        {
            //Arrange
            userController = new UserController();
            UserModel userModel = new UserModel
            {
                First_Name = " First Name test ",
                Last_Name = " Last Name test",
                Employee_ID = "2",
                Project_ID = 2003,
                IsActive = true
            };
            //Act
            int returnVal = userController.InserUserModel(userModel);

            //Assert            
            Assert.IsNotNull(returnVal);
            Assert.AreEqual(1, returnVal);
        }


        /// <summary>
        /// Update User and get success
        /// </summary>
        [TestMethod]
        public void UpdateUserDetails_Successfully()
        {
            //Arrange
            userController = new UserController();
            UserModel userModel = new UserModel
            {
                User_ID=1,
                First_Name = "Updated first Name",
                Last_Name = "Updated last name",
                Employee_ID = "344567",
                Project_ID = 2003,
                IsActive = true
            };
            //Act
            int returnVal = userController.UpdateUserModel(userModel);

            //Assert            
            Assert.IsNotNull(returnVal);
            Assert.AreEqual(1, returnVal);
        }
    }
}
