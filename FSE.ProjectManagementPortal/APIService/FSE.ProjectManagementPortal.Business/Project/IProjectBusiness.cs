using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;

namespace FSE.ProjectManagementPortal.Business
{
    public interface IProjectBusiness
    {
        List<ProjectModel> GetProjectList();
        int InsertProjectDetails(ProjectModel prjModel);
        int UpdateProjectDetails(ProjectModel prjModel);
    }
}
