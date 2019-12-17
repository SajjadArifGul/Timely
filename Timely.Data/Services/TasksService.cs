using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.Data.Services
{
    public class TasksService
    {
        TimelyContext context = new TimelyContext();

        #region Define as Singleton
        private static TasksService _Instance;

        public static TasksService Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TasksService();
                }

                return (_Instance);
            }
        }

        private TasksService()
        {
        }
        #endregion

        public List<Entities.Task> GetAll()
        {
            return context.Tasks.OrderByDescending(x => x.CreatedOn).ToList();
        }

        public Entities.Task GetTaskByID(int ID)
        {
            return context.Tasks.Find(ID);
        }

        public bool SaveTask(Entities.Task task)
        {
            context.Tasks.Add(task);

            return context.SaveChanges() > 0;
        }

        public bool UpdateTask(Entities.Task task)
        {
            using (var newContext = new TimelyContext())
            {
                var dbTask = newContext.Tasks.Find(task.ID);

                newContext.Entry(dbTask).CurrentValues.SetValues(task);

                //newContext.Entry(task).State = System.Data.Entity.EntityState.Modified;

                return newContext.SaveChanges() > 0;
            }
        }

        public bool DeleteTask(Entities.Task task)
        {
            context.Entry(task).State = System.Data.Entity.EntityState.Deleted;

            return context.SaveChanges() > 0;
        }
    }
}
