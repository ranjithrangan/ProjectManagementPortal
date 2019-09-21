using FSE.ProjectManagementPorta.DataAccess;
using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;

namespace FSE.ProjectManagementPortal.Business
{
    public class UserBusiness : IUserBusiness
    {
        UserDataAccess userDataAccess = null;
        public UserBusiness()
        {
            userDataAccess = new UserDataAccess();
        }

        public List<UserModel> GetUserList()
        {
            return userDataAccess.GetUserList();
        }

        public int InsertUserDetails(UserModel userModel)
        {
            return userDataAccess.InsertUserDetails(userModel);
        }

        public int UpdateUserDetails(UserModel userModel)
        {
            return userDataAccess.UpdateUserDetails(userModel);
        }

        public int DeleteUser(UserModel userModel)
        {
            return userDataAccess.DeleteUserDetails(userModel);
        }
    }
}
