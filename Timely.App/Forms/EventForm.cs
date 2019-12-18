using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timely.App.Code;

namespace Timely.App.Forms
{
    public partial class EventForm : Form
    {
        private Entities.Event Event = null;

        public EventForm(Entities.Event _event)
        {
            InitializeComponent();

            this.Event = _event;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            EventTimer.Start();
        }

        private void EventTimer_Tick(object sender, EventArgs e)
        {
            if (Event != null && Event.Status == Entities.EventStatus.Started)
            {
                var ts = DateTime.Now - Event.StartTime;
                lblTime.Text = ts.ToDigitalTimelyStandard().IfNullOrEmptyShowAlternative("-");
                lblDetailedTime.Text = ts.ToTimelyStandard().IfNullOrEmptyShowAlternative("-");
            }
        }
    }
}
