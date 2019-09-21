using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;
namespace FSE.ProjectManagementPortal.DataAccess
{
    public interface IUserDataAccess
    {
        List<UserModel> GetUserList();
        int InsertUserDetails(UserModel taskModel);
        int UpdateUserDetails(UserModel taskModel);
        int DeleteUserDetails(UserModel taskModel);
    }
}
