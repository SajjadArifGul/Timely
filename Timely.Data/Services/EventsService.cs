using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.Data.Services
{
    public class EventsService
    {
        TimelyContext context = null;

        #region Define as Singleton
        private static EventsService _Instance;

        public static EventsService Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new EventsService();
                }

                return (_Instance);
            }
        }

        private EventsService()
        {
            context = ContextHolder.Instance.TimelyContext();
        }
        #endregion

        public List<Entities.Event> GetAllEventsByTaskID(int taskID)
        {
            var task = context.Tasks.Find(taskID);
            return task.EventsHistory.OrderByDescending(x => x.StartTime).ToList();
        }

        public Entities.Event GetEventByID(int ID)
        {
            return context.Events.Find(ID);
        }

        public bool SaveEvent(Entities.Event _event)
        {
            context.Events.Add(_event);

            return context.SaveChanges() > 0;
        }

        public bool UpdateEvent(Entities.Event _event)
        {
            using (var newContext = new TimelyContext())
            {
                var dbEvent = newContext.Events.Find(_event.ID);

                newContext.Entry(dbEvent).CurrentValues.SetValues(_event);
                
                return newContext.SaveChanges() > 0;
            }
        }

        public bool DeleteEvent(Entities.Event _event)
        {
            context.Entry(_event).State = EntityState.Deleted;

            return context.SaveChanges() > 0;
        }
    }
}
