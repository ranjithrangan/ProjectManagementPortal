using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;

namespace FSE.ProjectManagementPortal.Business
{
    public interface ITaskManagerBusiness
    {
        List<ParentTaskDetails> GetParentTask();
        List<TaskModel> GetAllTask();
        int InsertTask(TaskModel taskModel);
        int UpdateTask(TaskModel taskModel);
    }
}
