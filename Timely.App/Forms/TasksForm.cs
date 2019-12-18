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
using Timely.App.Code;
using Timely.Data.Services;

namespace Timely.App.Forms
{
    public partial class TasksForm : Form
    {
        private Entities.Task SelectedTask = null;
        private Entities.Event SelectedEvent = null;

        public TasksForm()
        {
            InitializeComponent();
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            LoadTasks();

            AppTimer.Start();
        }

        private void LoadTasks(Entities.Task task = null)
        {
            var allTasks = TasksService.Instance.GetAll();

            lbTasksList.DataSource = allTasks;
            lbTasksList.DisplayMember = "Name";
            lbTasksList.ValueMember = "ID";

            if(task != null)
            {
                lbTasksList.SelectedItem = task;
            }
            else
            {
                if(allTasks != null && allTasks.Count > 0)
                {
                    lbTasksList.SelectedItem = allTasks.FirstOrDefault();
                }
                else gbTaskDetailsHolder.Enabled = false;
            }
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            var newTask = new Entities.Task() { Name = txtNewTaskName.Text, CreatedOn = DateTime.Now };

            if (ValidateTask(newTask))
            {
                var result = TasksService.Instance.SaveTask(newTask);

                if(!result)
                {
                    ShowErrorMessage("Unable to add task.");
                }
                else
                {
                    txtNewTaskName.Clear();

                    //Load Tasks again
                    LoadTasks(newTask);
                }
            }
            else
            {
                ShowErrorMessage("Please enter valid task name.");
            }
        }

        private void lbTasksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTask = (Entities.Task)lbTasksList.SelectedItem;

            if (selectedTask != null)
            {
                SelectedTask = selectedTask;

                LoadTaskDetails(SelectedTask);

                gbTaskDetailsHolder.Enabled = true;
            }
            else
            {
                gbTaskDetailsHolder.Enabled = false;
            }
        }

        private void LoadTaskDetails(Entities.Task task)
        {
            txtTaskName.Text = task.Name;
            txtTaskDescription.Text = task.Description;

            var taskHistory = task.EventsHistory != null ? task.EventsHistory.OrderByDescending(x => x.StartTime).ToList() : new List<Entities.Event>();

            var ts = TimeSpan.FromTicks(taskHistory.Sum(x => x.Ticks));

            lblTaskDuration.Text = ts.ToTimelyStandard().IfNullOrEmptyShowAlternative("-");

            lbTaskEventsHistory.DataSource = taskHistory;
            lbTaskEventsHistory.DisplayMember = "StartTime";
            lbTaskEventsHistory.ValueMember = "ID";

            if (taskHistory != null && taskHistory.Count > 0)
            {
                lbTaskEventsHistory.Enabled = true;
                btnDeleteEvent.Enabled = true;

                lbTaskEventsHistory.SelectedItem = taskHistory.FirstOrDefault();
            }
            else
            {
                SelectedEvent = null;

                lbTaskEventsHistory.Enabled = false;
                btnDeleteEvent.Enabled = false;
            }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            SelectedTask.Name = txtTaskName.Text;
            SelectedTask.Description = txtTaskDescription.Text;

            if (ValidateTask(SelectedTask))
            {
                var result = TasksService.Instance.UpdateTask(SelectedTask);

                if (!result)
                {
                    ShowErrorMessage("Unable to update task.");
                }
                else
                {
                    if(ShowSuccessMessage("Task updated.") == DialogResult.OK)
                    {
                        //Load Tasks again
                        LoadTasks(SelectedTask);
                    }
                }
            }
            else
            {
                ShowErrorMessage("Please enter valid task name.");
            }
        }

        private DialogResult ShowErrorMessage(string message)
        {
            return MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DialogResult ShowSuccessMessage(string message)
        {
            return MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult ShowConfirmMessage(string message)
        {
            return MessageBox.Show(message, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (ShowConfirmMessage("Are you sure you want to delete this task?") == DialogResult.OK)
            {
                var result = TasksService.Instance.DeleteTask(SelectedTask);

                if (!result)
                {
                    ShowErrorMessage("Unable to delete task.");
                }
                else
                {
                    if (ShowSuccessMessage("Task deleted.") == DialogResult.OK)
                    {
                        txtTaskName.Clear();

                        //Load Tasks again
                        LoadTasks();
                    }
                }
            }
        }

        private bool ValidateTask(Entities.Task task)
        {
            return !string.IsNullOrEmpty(task.Name);
        }

        private void btnStartNewEvent_Click(object sender, EventArgs e)
        {
            var newEvent = new Entities.Event() { TaskID = SelectedTask.ID, StartTime = DateTime.Now, Status = Entities.EventStatus.Started };

            if(SelectedTask.EventsHistory == null)
            {
                SelectedTask.EventsHistory = new List<Entities.Event>();
            }

            SelectedTask.EventsHistory.Add(newEvent);
            
            var result = EventsService.Instance.SaveEvent(newEvent);

            if (!result)
            {
                ShowErrorMessage("Unable to add event.");
            }
            else
            {
                //Load Tasks again
                LoadTasks(SelectedTask);
            }
        }

        private void lbTaskEventsHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEvent = (Entities.Event)lbTaskEventsHistory.SelectedItem;

            if (selectedEvent != null)
            {
                SelectedEvent = selectedEvent;
                btnDeleteEvent.Enabled = true;
            }
            else
            {
                SelectedEvent = null;
                btnDeleteEvent.Enabled = false;
            }
        }
        
        private void AppTimer_Tick(object sender, EventArgs e)
        {
            if(SelectedEvent != null && SelectedEvent.Status == Entities.EventStatus.Started)
            {
                var ts = DateTime.Now - SelectedEvent.StartTime;
                lblTaskDuration.Text = ts.ToTimelyStandard().IfNullOrEmptyShowAlternative("-");
            }
        }
    }
}
