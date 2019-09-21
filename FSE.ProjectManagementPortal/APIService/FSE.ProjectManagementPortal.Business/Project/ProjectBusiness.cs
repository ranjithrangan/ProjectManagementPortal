using FSE.ProjectManagementPortal.DataAccess;
using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;

namespace FSE.ProjectManagementPortal.Business
{
    public class ProjectBusiness : IProjectBusiness
    {
        ProjectDataAccess projectDataAccess = null;
        public ProjectBusiness()
        {
            projectDataAccess = new ProjectDataAccess();
        }
        public List<ProjectModel> GetProjectList()
        {
            return projectDataAccess.GetAllProject();
        }

        public int InsertProjectDetails(ProjectModel prjModel)
        {
            return projectDataAccess.InsertProjectDetails(prjModel);
        }

        public int UpdateProjectDetails(ProjectModel prjModel)
        {
            return projectDataAccess.UpdateProjectDetails(prjModel);
        }
    }
}
