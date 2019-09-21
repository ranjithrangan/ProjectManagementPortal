using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;
namespace FSE.ProjectManagementPortal.DataAccess
{
    public interface IProjectDataAccess
    {
        List<ProjectModel> GetAllProject();
        int InsertProjectDetails(ProjectModel prjModel);
        int UpdateProjectDetails(ProjectModel prjModel);
    }
}
