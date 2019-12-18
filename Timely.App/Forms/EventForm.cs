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

namespace Timely.App.Forms
{
    public partial class EventForm : Form
    {
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private Entities.Event Event = null;

        public EventForm(Entities.Event _event)
        {
            InitializeComponent();

            TopMost = true;

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
