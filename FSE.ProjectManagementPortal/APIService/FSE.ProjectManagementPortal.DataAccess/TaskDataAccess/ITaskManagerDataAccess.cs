using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;

namespace FSE.ProjectManagementPortal.DataAccess
{
    public interface ITaskManagerDataAccess
    {
        List<ParentTaskDetails> GetParentTaskRepository();
        List<TaskModel> GetAllTaskRepository();
        int InsertTaskRepository(TaskModel taskModel);
        int UpdateTaskRepository(TaskModel taskModel);
    }
}
