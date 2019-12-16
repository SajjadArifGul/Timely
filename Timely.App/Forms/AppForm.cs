using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timely.App.Forms
{
    public partial class AppForm : Form
    {
        Stopwatch sw = Stopwatch.StartNew();

        public AppForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ts = TimeSpan.FromTicks(sw.ElapsedTicks);
            //lblTime.Text = string.Format("{0} : {1} : {2} : {3}", ts.Hours.ToString("00"), ts.Minutes.ToString("00"), ts.Seconds.ToString("00"), ts.Milliseconds.ToString("00"));
            lblTime.Text = string.Format("{0} : {1} : {2} : {3}", ts.ToString("hh"), ts.ToString("mm"), ts.ToString("ss"), ts.ToString("ff"));

            //lblTime.Text = ts.ToString("hh\\:mm\\:ss\\:ff");
        }
    }
}
