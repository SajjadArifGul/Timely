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
            context = new TimelyContext();

            return context.Tasks.OrderByDescending(x => x.CreatedOn).ToList();
        }

        public Task<List<Entities.Task>> GetAllAsync()
        {
            return Task.Run(() =>
            {
                context = new TimelyContext();

                return context.Tasks.OrderByDescending(x => x.CreatedOn).ToList();
            });
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
            context.Entry(task).State = EntityState.Modified;
            return context.SaveChanges() > 0;

            //using (var newContext = new TimelyContext())
            //{
            //    var dbTask = newContext.Tasks.Find(task.ID);

            //    newContext.Entry(dbTask).CurrentValues.SetValues(task);

            //    return newContext.SaveChanges() > 0;
            //}
        }

        public bool DeleteTask(Entities.Task task)
        {
            context.Events.RemoveRange(task.EventsHistory);

            context.Entry(task).State = EntityState.Deleted;

            return context.SaveChanges() > 0;
        }
    }
}
