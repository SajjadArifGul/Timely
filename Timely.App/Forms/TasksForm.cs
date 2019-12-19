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
    public partial class TasksForm : FormBase
    {
        protected internal List<Entities.Task> Tasks = null;
        
        #region Define as Singleton
        private static TasksForm _Instance;

        public static TasksForm Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TasksForm();
                }

                return (_Instance);
            }
        }

        private TasksForm()
        {
            InitializeComponent();
            this.Icon = new Icon("Resources/timely-icon.ico");
        }
        #endregion
        
        #region Form Events
        private void TasksForm_Load(object sender, EventArgs e)
        {
            UpdateTasksListBoxSource(Tasks);

            AppTimer.Start();
        }

        private void lbTasksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTaskDetails((Entities.Task)lbTasksList.SelectedItem);
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            var newTask = new Entities.Task() { Name = txtNewTaskName.Text, CreatedOn = DateTime.Now };

            var taskValidation = Validators.ValidateTask(newTask);
            if (string.IsNullOrEmpty(taskValidation))
            {
                var result = TasksService.Instance.SaveTask(newTask);

                if (!result)
                {
                    ShowErrorMessage("Unable to add task.");
                }
                else
                {
                    txtNewTaskName.Clear();

                    //Load Tasks again so it can have the new task in list
                    ReloadTasks();

                    //Update Tasks Source in Listbox
                    UpdateTasksListBoxSource(Tasks);
                }
            }
            else
            {
                ShowErrorMessage(taskValidation);
            }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            var selectedTask = (Entities.Task)lbTasksList.SelectedItem;

            if (selectedTask == null)
            {
                LoadTaskDetails(selectedTask);
                return;
            }

            selectedTask.Name = txtTaskName.Text;
            selectedTask.Description = txtTaskDescription.Text;

            var taskValidation = Validators.ValidateTask(selectedTask);
            if (string.IsNullOrEmpty(taskValidation))
            {
                var result = TasksService.Instance.UpdateTask(selectedTask);

                if (!result)
                {
                    ShowErrorMessage("Unable to update task.");
                }
                else
                {
                    ShowSuccessMessage("Task updated.");

                    //Update Tasks Source in Listbox
                    UpdateTasksListBoxSource(Tasks, selectedTask.ID);
                }
            }
            else
            {
                ShowErrorMessage(taskValidation);
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            var selectedTask = (Entities.Task)lbTasksList.SelectedItem;

            if (selectedTask == null)
            {
                LoadTaskDetails(selectedTask);
                return;
            }

            if (ShowConfirmMessage("Are you sure you want to delete this task?") == DialogResult.OK)
            {
                var result = TasksService.Instance.DeleteTask(selectedTask);

                if (!result)
                {
                    ShowErrorMessage("Unable to delete task.");
                }
                else
                {
                    //Load Tasks again so it can remove the deleted task from list
                    ReloadTasks();

                    //Update Tasks Source in Listbox
                    UpdateTasksListBoxSource(Tasks);
                }
            }
        }

        private void btnStartNewEvent_Click(object sender, EventArgs e)
        {
            var selectedTask = (Entities.Task)lbTasksList.SelectedItem;

            if (selectedTask == null)
            {
                LoadTaskDetails(selectedTask);
                return;
            }

            var newEvent = new Entities.Event() { TaskID = selectedTask.ID, StartTime = DateTime.Now, Status = Entities.EventStatus.Started };

            if (selectedTask.EventsHistory == null) selectedTask.EventsHistory = new List<Entities.Event>();

            selectedTask.EventsHistory.Add(newEvent);

            var result = TasksService.Instance.UpdateTask(selectedTask);

            if (!result)
            {
                ShowErrorMessage("Unable to add event.");
            }
            else
            {
                //reload task details
                LoadTaskDetails(selectedTask);
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            var selectedTask = (Entities.Task)lbTasksList.SelectedItem;

            if (selectedTask == null)
            {
                LoadTaskDetails(selectedTask);
                return;
            }

            var selectedEvent = (Entities.Event)lbTaskEventsHistory.SelectedItem;

            if (selectedEvent != null && selectedTask.EventsHistory != null && ShowConfirmMessage("Are you sure you want to delete this event?") == DialogResult.OK)
            {
                var selectedTaskEvent = selectedTask.EventsHistory.FirstOrDefault(x => x.ID == selectedEvent.ID);

                selectedTask.EventsHistory.Remove(selectedTaskEvent);

                var resultDeleteEvent = EventsService.Instance.DeleteEvent(selectedEvent);
                //var result = TasksService.Instance.UpdateTask(selectedTask);

                if (!resultDeleteEvent)// || !result)
                {
                    ShowErrorMessage("Unable to delete event.");
                }
                else
                {
                    //reload task details
                    LoadTaskDetails(selectedTask);
                }
            }
        }
        private void lbTaskEventsHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEvent = (Entities.Event)lbTaskEventsHistory.SelectedItem;

            if (selectedEvent != null)
            {
                btnDeleteEvent.Enabled = true;
            }
            else
            {
                btnDeleteEvent.Enabled = false;
            }
        }

        private void lbTaskEventsHistory_DoubleClick(object sender, EventArgs e)
        {
            var selectedTask = (Entities.Task)lbTasksList.SelectedItem;

            if (selectedTask == null)
            {
                LoadTaskDetails(selectedTask);
                return;
            }

            var selectedEvent = (Entities.Event)lbTaskEventsHistory.SelectedItem;

            if (selectedEvent != null)
            {
                var eventForm = new EventForm(selectedTask, selectedEvent.ID);
                eventForm.Show();
            }
        }

        private void AppTimer_Tick(object sender, EventArgs e)
        {
            var selectedTask = (Entities.Task)lbTasksList.SelectedItem;

            if (selectedTask == null)
            {
                LoadTaskDetails(selectedTask);
                return;
            }

            if (selectedTask != null)
            {
                var sumOfTicksOfStoppedEvents = selectedTask.EventsHistory == null ? 0 : selectedTask.EventsHistory.Where(x => x.Status == Entities.EventStatus.Stopped && x.EndTime.HasValue).Select(x => (x.EndTime.Value - x.StartTime).Ticks).Sum();

                ///Ideally we shouldn't have more than one event with status = Started.
                ///One man can work on one issue of task at a time
                ///but lets just say someone is as much a multitasker as I am :p
                var sumOfTicksOfStartedEvents = selectedTask.EventsHistory == null ? 0 : selectedTask.EventsHistory.Where(x => x.Status == Entities.EventStatus.Started).Select(x => (DateTime.Now - x.StartTime).Ticks).Sum();

                var ts = TimeSpan.FromTicks(sumOfTicksOfStoppedEvents + sumOfTicksOfStartedEvents);

                lblTaskDuration.Text = ts.ToTimelyStandard().IfNullOrEmptyShowAlternative("-");
            }
        }

        private void TasksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Functions
        protected internal void ReloadTasks()
        {
            Tasks = TasksService.Instance.GetAll();
        }

        private void UpdateTasksListBoxSource(List<Entities.Task> tasks, int selectedID = 0)
        {
            if (tasks != null && tasks.Count > 0)
            {
                var tasksSource = new BindingSource();
                tasksSource.DataSource = tasks;

                lbTasksList.DataSource = tasksSource;
                lbTasksList.DisplayMember = "Name";
                lbTasksList.ValueMember = "ID";

                if (selectedID > 0)
                {
                    lbTasksList.SelectedItem = tasks.FirstOrDefault(x => x.ID == selectedID);
                }
            }
            else
            {
                lbTasksList.DataSource = null;
            }
        }

        private void UpdateEventsListBoxSource(List<Entities.Event> _events, int selectedID = 0)
        {
            if (_events != null && _events.Count > 0)
            {
                var eventsSource = new BindingSource();
                eventsSource.DataSource = _events;

                lbTaskEventsHistory.DataSource = eventsSource;
                lbTaskEventsHistory.DisplayMember = "Name";
                lbTaskEventsHistory.ValueMember = "ID";

                if (selectedID > 0)
                {
                    lbTaskEventsHistory.SelectedItem = _events.FirstOrDefault(x => x.ID == selectedID);
                }

            }
            else
            {
                lbTaskEventsHistory.DataSource = null;
                btnDeleteEvent.Enabled = false;
            }
        }

        protected internal void LoadTaskDetails(Entities.Task task)
        {
            if (task != null)
            {
                gbTaskDetailsHolder.Enabled = true;

                txtTaskName.Text = task.Name;
                txtTaskDescription.Text = task.Description;

                var taskEvents = task.EventsHistory != null ? task.EventsHistory.OrderByDescending(x => x.StartTime).ToList() : new List<Entities.Event>();
                UpdateEventsListBoxSource(taskEvents);

                lblTaskDuration.Text = string.Empty;

                if (taskEvents != null && taskEvents.Count > 0)
                {
                    lbTaskEventsHistory.Enabled = true;
                    btnDeleteEvent.Enabled = true;
                }
                else
                {
                    lbTaskEventsHistory.Enabled = false;
                    btnDeleteEvent.Enabled = false;
                }
            }
            else
            {
                gbTaskDetailsHolder.Enabled = false;
                txtTaskName.Clear();
                txtTaskDescription.Clear();
                lblTaskDuration.Text = string.Empty;

                UpdateEventsListBoxSource(null);
            }
        }

        #endregion
        
    }
}
