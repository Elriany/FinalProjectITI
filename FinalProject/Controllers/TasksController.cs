using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using BL.Classes;
using BL.Models;
namespace FinalProject.Controllers
{
    public class TasksController : ApiController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        // GET: api/Tasks
        public IEnumerable<TaskCustom> Get()
        {
            return unitOfWork.TaskManager.GetAllBind().Select(t=> new TaskCustom { id = t.id,taskName=t.taskName });
        }

        // GET: api/Tasks/5
        public TaskCustom Get(int id)
        {
            var taskEntity = unitOfWork.TaskManager.GetByID(id);
            TaskCustom task = new TaskCustom();
            task.id = taskEntity.id;
            task.taskName = taskEntity.taskName;
            return task;
        }

        // POST: api/Tasks
        public bool Post(tbl_Task task)
        {
            return unitOfWork.TaskManager.AddEntity(task);
        }

        // PUT: api/Tasks/5
        public bool Put(tbl_Task task)
        {
            return unitOfWork.TaskManager.UpdateEntity(task);
        }

        // DELETE: api/Tasks/5
        public bool Delete(int id)
        {
            return unitOfWork.TaskManager.DeleteEntity(unitOfWork.TaskManager.GetByID(id));
        }
    }
}
