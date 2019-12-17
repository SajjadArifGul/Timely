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
    public partial class TasksForm : Form
    {
        private Entities.Task SelectedTask = null;

        public TasksForm()
        {
            InitializeComponent();
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            LoadTasks();
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
            }
        }

        private void LoadTaskDetails(Entities.Task task)
        {
            txtTaskName.Text = task.Name;
            txtTaskDescription.Text = task.Description;
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
    }
}
