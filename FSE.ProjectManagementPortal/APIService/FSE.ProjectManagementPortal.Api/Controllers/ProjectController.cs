using FSE.ProjectManagementPortal.Business;
using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;
using System.Web.Http;
namespace FSE.ProjectManagementPortal.Api.Controllers
{
    public class ProjectController : ApiController
    {
        ProjectBusiness projectBusiness;

        [HttpGet]
        [Route("api/ProjectManager/Project/GetAll")]
        public List<ProjectModel> GetAllProjectDetails()
        {
            projectBusiness = new ProjectBusiness();
            List<ProjectModel> result = projectBusiness.GetProjectList();

            return result;
        }

        [HttpPost]
        [Route("api/ProjectManager/Project/Insert")]
        public int InserProjectModel(ProjectModel prjModel)
        {
            projectBusiness = new ProjectBusiness();
            int result = projectBusiness.InsertProjectDetails(prjModel);
            return result;
        }
        [HttpPost]
        [Route("api/ProjectManager/Project/Update")]
        public int UpdaterojectModel(ProjectModel prjModel)
        {
            projectBusiness = new ProjectBusiness();
            int result = projectBusiness.UpdateProjectDetails(prjModel);
            return result;
        }

    }
}
