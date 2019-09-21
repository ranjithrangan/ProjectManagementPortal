using FSE.ProjectManagementPortal.Business;
using FSE.ProjectManagementPortal.DataContract;
using System.Collections.Generic;
using System.Web.Http;

namespace FSE.ProjectManagementPortal.Api.Controllers
{
    public class TaskManagerController : ApiController
    {
        TaskManagerBusiness taskMgrBusiness;

        [HttpGet]
        [Route("api/TaskManager/GetParentTask")]
        public List<ParentTaskDetails> GetParentTask()
        {
            taskMgrBusiness = new TaskManagerBusiness();
            List<ParentTaskDetails> result = taskMgrBusiness.GetParentTask();
            return result;
        }

        [HttpGet]
        [Route("api/TaskManager/ViewTask")]
        public List<TaskModel> GetAllTask()
        {
            taskMgrBusiness = new TaskManagerBusiness();
            var result = taskMgrBusiness.GetAllTask();
            return result;
        }

        [HttpPost]
        [Route("api/TaskManager/AddTask")]
        public int InsertTaskDetails(TaskModel task)
        {
            int result = 0;
            if (ModelState.IsValid)
            {
                taskMgrBusiness = new TaskManagerBusiness();
                result = taskMgrBusiness.InsertTask(task);
            }
            return result;
        }

        [HttpPost]
        [Route("api/TaskManager/EditTask")]
        public int UpdateEndTask(TaskModel task)
        {
            int result = 0;
            
            if (ModelState.IsValid)
            {
                taskMgrBusiness = new TaskManagerBusiness();
                result = taskMgrBusiness.UpdateTask(task);
            }
            return result;
        }

    }
}
