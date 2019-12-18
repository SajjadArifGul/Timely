using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return context.Tasks.Include("EventsHistory").OrderByDescending(x => x.CreatedOn).ToList();
        }

        public Entities.Task GetTaskByID(int ID)
        {
            return context.Tasks.Where(x=>x.ID == ID).Include("EventsHistory").FirstOrDefault();
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
            using (var newContext = new TimelyContext())
            {
                var dbTask = newContext.Tasks.Where(x => x.ID == task.ID).Include("EventsHistory").FirstOrDefault();

                //newContext.Entry(dbTask).CurrentValues.SetValues(task);

                //newContext.Entry(dbTask.EventsHistory).State = System.Data.Entity.EntityState.Deleted;

                //dbTask.EventsHistory.ForEach(x => newContext.Entry(x).State = System.Data.Entity.EntityState.Deleted);

                foreach (var taskevent in dbTask.EventsHistory)
                {
                    newContext.Entry(taskevent).State = System.Data.Entity.EntityState.Deleted;
                }

                newContext.Entry(dbTask).State = System.Data.Entity.EntityState.Deleted;

                return newContext.SaveChanges() > 0;
            }

            //context.Entry(task.EventsHistory).State = System.Data.Entity.EntityState.Deleted;
            //context.Entry(task).State = System.Data.Entity.EntityState.Deleted;

            //return context.SaveChanges() > 0;
        }
    }
}
