using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timely.Data.Services;

namespace Timely.App.Forms
{
    public partial class LoaderForm : Form
    {
        public LoaderForm()
        {
            InitializeComponent();
        }

        private async void LoaderForm_Load(object sender, EventArgs e)
        {
            TasksForm.Instance.Tasks = await TasksService.Instance.GetAllAsync();

            this.Hide();
            TasksForm.Instance.ShowDialog();
        }
    }
}
