using FSE.ProjectManagementPortal.Business;
using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;
using System.Web.Http;

namespace FSE.ProjectManagementPortal.Api.Controllers
{
    public class UserController : ApiController
    {
        UserBusiness userMgrBusiness;

        [HttpGet]
        [Route("api/ProjectManager/User/GetAll")]
        public List<UserModel> GetAllUserDetails()
        {
            userMgrBusiness = new UserBusiness();
            List<UserModel> result = userMgrBusiness.GetUserList();
            return result;
        }

        [HttpPost]
        [Route("api/ProjectManager/User/Insert")]
        public int InserUserModel(UserModel userModel)
        {
            userMgrBusiness = new UserBusiness();
            int result = userMgrBusiness.InsertUserDetails(userModel);
            return result;
        }
        [HttpPost]
        [Route("api/ProjectManager/User/Update")]
        public int UpdateUserModel(UserModel userModel)
        {
            userMgrBusiness = new UserBusiness();
            int result = userMgrBusiness.UpdateUserDetails(userModel);
            return result;
        }

        [HttpPost]
        [Route("api/ProjectManager/User/Delete")]
        public int DeleteUserModel(UserModel userModel)
        {
            userMgrBusiness = new UserBusiness();
            int result = userMgrBusiness.DeleteUser(userModel);
            return result;
        }
    }
}
