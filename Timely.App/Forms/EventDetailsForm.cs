using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timely.App.Code;
using Timely.Data.Services;

namespace Timely.App.Forms
{
    public partial class EventDetailsForm : FormBase
    {
        private Entities.Task Task = null;
        private Entities.Event SelectedEvent = null;

        public EventDetailsForm(Entities.Task task, int selectedEventID)
        {
            InitializeComponent();

            TopMost = true;

            this.Task = task;
            this.SelectedEvent = task.EventsHistory.FirstOrDefault(x=>x.ID == selectedEventID);
        }

        private void EventDetailsForm_Load(object sender, EventArgs e)
        {
            if(Task != null && SelectedEvent != null)
            {
                if(SelectedEvent.EndTime.HasValue)
                {
                    var ts = SelectedEvent.EndTime.Value - SelectedEvent.StartTime;

                    lblTime.Text = ts.ToTimelyStandard();
                }

                lblTaskName.Text = Task.Name;
                lblStatus.Text = SelectedEvent.Status.ToString();
                lblStartedOn.Text = SelectedEvent.StartTime.ToString();
                lblEndedOn.Text = SelectedEvent.EndTime.HasValue ? SelectedEvent.EndTime.Value.ToString() : "-";
            }
        }
    }
}
