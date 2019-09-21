
using FSE.ProjectManagementPortal.DataAccess;
using FSE.ProjectManagementPortal.DataContract;
using System;
using System.Collections.Generic;

namespace FSE.ProjectManagementPortal.Business
{
    public class TaskManagerBusiness : ITaskManagerBusiness
    {
        TaskManagerDataAccess taskManagerDataAccess = null;

        public TaskManagerBusiness()
        {
            taskManagerDataAccess = new TaskManagerDataAccess();
        }
        /// <summary>
        /// Get the all parent task details
        /// </summary>
        /// <returns></returns>
        public List<ParentTaskDetails> GetParentTask()
        {
            List<ParentTaskDetails> parentTaskList = taskManagerDataAccess.GetParentTaskRepository();
            return parentTaskList;
        }

        /// <summary>
        /// To get the task details by parent Id
        /// </summary>
        /// <returns></returns>
        public List<TaskModel> GetAllTask()
        {
            List<TaskModel> taskModel = taskManagerDataAccess.GetAllTaskRepository();
            return taskModel;
        }

        /// <summary>
        /// to save the task details
        /// </summary>
        /// <param name="taskModel"></param>
        /// <returns></returns>
        public int InsertTask(TaskModel taskModel)
        {
            int returnVal = 0;
            try
            {
                returnVal = taskManagerDataAccess.InsertTaskRepository(taskModel);
            }
            catch (Exception)
            {

                return returnVal;
            }
            return returnVal;
        }

        /// <summary>
        /// to Update the existing task details
        /// </summary>
        /// <param name="taskModel"></param>
        /// <returns></returns>
        public int UpdateTask(TaskModel taskModel)
        {
            int returnVal = 0;
            try
            {
                returnVal = taskManagerDataAccess.UpdateTaskRepository(taskModel);
            }
            catch (Exception)
            {

                return returnVal;
            }
            return returnVal;
        }
    }
}
