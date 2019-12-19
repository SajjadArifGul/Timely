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
    public partial class EventForm : FormBase
    {
        #region Keeping Form the top most
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        #endregion

        private Entities.Task Task = null;
        private Entities.Event SelectedEvent = null;

        public EventForm(Entities.Task task, int selectedEventID)
        {
            InitializeComponent();

            TopMost = true;

            this.Task = task;
            this.SelectedEvent = task.EventsHistory.FirstOrDefault(x=>x.ID == selectedEventID);
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            EventTimer.Start();
        }

        private void EventTimer_Tick(object sender, EventArgs e)
        {
            if (SelectedEvent != null && SelectedEvent.Status == Entities.EventStatus.Started)
            {
                var ts = DateTime.Now - SelectedEvent.StartTime;
                lblTime.Text = ts.ToDigitalTimelyStandard().IfNullOrEmptyShowAlternative("-");
                lblDetailedTime.Text = ts.ToTimelyStandard().IfNullOrEmptyShowAlternative("-");
            }
        }

        private void btnStopEvent_Click(object sender, EventArgs e)
        {
            if(SelectedEvent.Status == Entities.EventStatus.Stopped)
            {
                ShowErrorMessage("This event is already stopped.");
            }
            else
            {
                SelectedEvent.Status = Entities.EventStatus.Stopped;
                SelectedEvent.EndTime = DateTime.Now;

                var result = EventsService.Instance.UpdateEvent(SelectedEvent);

                if (!result)
                {
                    TasksForm.Instance.ShowErrorMessage("Unable to update event status.");
                }
                else
                {
                    TasksForm.Instance.LoadTaskDetails(Task);
                }
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (ShowConfirmMessage("Are you sure you want to delete this event?") == DialogResult.OK)
            {
                Task.EventsHistory.Remove(SelectedEvent);

                var resultDeleteEvent = EventsService.Instance.DeleteEvent(SelectedEvent);

                if (!resultDeleteEvent)
                {
                    ShowErrorMessage("Unable to delete event.");
                }
                else
                {
                    //reload task details
                    TasksForm.Instance.LoadTaskDetails(Task);
                    this.Close();
                }
            }
        }
    }
}
