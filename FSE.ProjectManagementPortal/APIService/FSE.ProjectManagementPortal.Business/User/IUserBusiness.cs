using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;


namespace FSE.ProjectManagementPortal.Business
{
    public interface IUserBusiness
    {
        List<UserModel> GetUserList();
        int InsertUserDetails(UserModel userModel);
        int UpdateUserDetails(UserModel userModel);
        int DeleteUser(UserModel userModel);        
    }
}
