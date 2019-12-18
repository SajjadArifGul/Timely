namespace Timely.App.Forms
{
    partial class TasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxTasksHolder = new System.Windows.Forms.GroupBox();
            this.txtNewTaskName = new System.Windows.Forms.TextBox();
            this.lbTasksList = new System.Windows.Forms.ListBox();
            this.gbTaskDetailsHolder = new System.Windows.Forms.GroupBox();
            this.lbTaskEventsHistory = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTaskDuration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnStartNewEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.gbxTasksHolder.SuspendLayout();
            this.gbTaskDetailsHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTasksHolder
            // 
            this.gbxTasksHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxTasksHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxTasksHolder.Controls.Add(this.btnAddNewTask);
            this.gbxTasksHolder.Controls.Add(this.txtNewTaskName);
            this.gbxTasksHolder.Controls.Add(this.lbTasksList);
            this.gbxTasksHolder.Location = new System.Drawing.Point(16, 13);
            this.gbxTasksHolder.Margin = new System.Windows.Forms.Padding(4);
            this.gbxTasksHolder.Name = "gbxTasksHolder";
            this.gbxTasksHolder.Padding = new System.Windows.Forms.Padding(4);
            this.gbxTasksHolder.Size = new System.Drawing.Size(266, 415);
            this.gbxTasksHolder.TabIndex = 0;
            this.gbxTasksHolder.TabStop = false;
            this.gbxTasksHolder.Text = "Tasks";
            // 
            // txtNewTaskName
            // 
            this.txtNewTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewTaskName.Font = new System.Drawing.Font("Segoe UI", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewTaskName.Location = new System.Drawing.Point(8, 26);
            this.txtNewTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewTaskName.Name = "txtNewTaskName";
            this.txtNewTaskName.Size = new System.Drawing.Size(206, 35);
            this.txtNewTaskName.TabIndex = 1;
            this.infoToolTip.SetToolTip(this.txtNewTaskName, "Add Task Name");
            // 
            // lbTasksList
            // 
            this.lbTasksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTasksList.FormattingEnabled = true;
            this.lbTasksList.IntegralHeight = false;
            this.lbTasksList.ItemHeight = 17;
            this.lbTasksList.Location = new System.Drawing.Point(8, 68);
            this.lbTasksList.Margin = new System.Windows.Forms.Padding(4);
            this.lbTasksList.Name = "lbTasksList";
            this.lbTasksList.Size = new System.Drawing.Size(249, 337);
            this.lbTasksList.TabIndex = 0;
            this.infoToolTip.SetToolTip(this.lbTasksList, "Tasks List");
            this.lbTasksList.SelectedIndexChanged += new System.EventHandler(this.lbTasksList_SelectedIndexChanged);
            this.lbTasksList.SelectedValueChanged += new System.EventHandler(this.lbTasksList_SelectedIndexChanged);
            // 
            // gbTaskDetailsHolder
            // 
            this.gbTaskDetailsHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTaskDetailsHolder.Controls.Add(this.btnStartNewEvent);
            this.gbTaskDetailsHolder.Controls.Add(this.btnDeleteEvent);
            this.gbTaskDetailsHolder.Controls.Add(this.lbTaskEventsHistory);
            this.gbTaskDetailsHolder.Controls.Add(this.label5);
            this.gbTaskDetailsHolder.Controls.Add(this.lblTaskDuration);
            this.gbTaskDetailsHolder.Controls.Add(this.panel1);
            this.gbTaskDetailsHolder.Controls.Add(this.label3);
            this.gbTaskDetailsHolder.Controls.Add(this.btnDeleteTask);
            this.gbTaskDetailsHolder.Controls.Add(this.btnUpdateTask);
            this.gbTaskDetailsHolder.Controls.Add(this.txtTaskDescription);
            this.gbTaskDetailsHolder.Controls.Add(this.label2);
            this.gbTaskDetailsHolder.Controls.Add(this.txtTaskName);
            this.gbTaskDetailsHolder.Controls.Add(this.label1);
            this.gbTaskDetailsHolder.Location = new System.Drawing.Point(290, 13);
            this.gbTaskDetailsHolder.Margin = new System.Windows.Forms.Padding(4);
            this.gbTaskDetailsHolder.Name = "gbTaskDetailsHolder";
            this.gbTaskDetailsHolder.Padding = new System.Windows.Forms.Padding(4);
            this.gbTaskDetailsHolder.Size = new System.Drawing.Size(540, 415);
            this.gbTaskDetailsHolder.TabIndex = 1;
            this.gbTaskDetailsHolder.TabStop = false;
            this.gbTaskDetailsHolder.Text = "Details";
            // 
            // lbTaskEventsHistory
            // 
            this.lbTaskEventsHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTaskEventsHistory.FormattingEnabled = true;
            this.lbTaskEventsHistory.IntegralHeight = false;
            this.lbTaskEventsHistory.ItemHeight = 17;
            this.lbTaskEventsHistory.Location = new System.Drawing.Point(114, 166);
            this.lbTaskEventsHistory.Name = "lbTaskEventsHistory";
            this.lbTaskEventsHistory.Size = new System.Drawing.Size(418, 194);
            this.lbTaskEventsHistory.TabIndex = 11;
            this.infoToolTip.SetToolTip(this.lbTaskEventsHistory, "Event History of Task");
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "History";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaskDuration
            // 
            this.lblTaskDuration.Location = new System.Drawing.Point(114, 140);
            this.lblTaskDuration.Margin = new System.Windows.Forms.Padding(3);
            this.lblTaskDuration.Name = "lblTaskDuration";
            this.lblTaskDuration.Size = new System.Drawing.Size(418, 20);
            this.lblTaskDuration.TabIndex = 9;
            this.lblTaskDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoToolTip.SetToolTip(this.lblTaskDuration, "Total Duration of Task");
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 1);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Duration";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskDescription.Location = new System.Drawing.Point(114, 59);
            this.txtTaskDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(418, 25);
            this.txtTaskDescription.TabIndex = 4;
            this.infoToolTip.SetToolTip(this.txtTaskDescription, "Task Description");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskName.Location = new System.Drawing.Point(114, 25);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(418, 25);
            this.txtTaskName.TabIndex = 2;
            this.infoToolTip.SetToolTip(this.txtTaskName, "Task Name");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStartNewEvent
            // 
            this.btnStartNewEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartNewEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartNewEvent.BackgroundImage = global::Timely.App.Properties.Resources.appbar_timer_check;
            this.btnStartNewEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartNewEvent.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnStartNewEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartNewEvent.Location = new System.Drawing.Point(497, 367);
            this.btnStartNewEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartNewEvent.Name = "btnStartNewEvent";
            this.btnStartNewEvent.Size = new System.Drawing.Size(35, 35);
            this.btnStartNewEvent.TabIndex = 14;
            this.infoToolTip.SetToolTip(this.btnStartNewEvent, "Start New Event");
            this.btnStartNewEvent.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEvent.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteEvent.BackgroundImage = global::Timely.App.Properties.Resources.appbar_timer_rewind;
            this.btnDeleteEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteEvent.Enabled = false;
            this.btnDeleteEvent.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnDeleteEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEvent.Location = new System.Drawing.Point(454, 367);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(35, 35);
            this.btnDeleteEvent.TabIndex = 13;
            this.infoToolTip.SetToolTip(this.btnDeleteEvent, "Delete Selected Event");
            this.btnDeleteEvent.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTask.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteTask.BackgroundImage = global::Timely.App.Properties.Resources.appbar_delete;
            this.btnDeleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTask.Location = new System.Drawing.Point(454, 92);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(35, 35);
            this.btnDeleteTask.TabIndex = 6;
            this.infoToolTip.SetToolTip(this.btnDeleteTask, "Delete Task");
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateTask.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateTask.BackgroundImage = global::Timely.App.Properties.Resources.appbar_list_create;
            this.btnUpdateTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateTask.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnUpdateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTask.Location = new System.Drawing.Point(497, 92);
            this.btnUpdateTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(35, 35);
            this.btnUpdateTask.TabIndex = 5;
            this.infoToolTip.SetToolTip(this.btnUpdateTask, "Update Task Info");
            this.btnUpdateTask.UseVisualStyleBackColor = false;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewTask.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewTask.BackgroundImage = global::Timely.App.Properties.Resources.appbar_list_star;
            this.btnAddNewTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewTask.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTask.Location = new System.Drawing.Point(222, 26);
            this.btnAddNewTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(35, 35);
            this.btnAddNewTask.TabIndex = 2;
            this.infoToolTip.SetToolTip(this.btnAddNewTask, "Add New Task");
            this.btnAddNewTask.UseVisualStyleBackColor = false;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 443);
            this.Controls.Add(this.gbTaskDetailsHolder);
            this.Controls.Add(this.gbxTasksHolder);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(862, 482);
            this.Name = "TasksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TasksForm";
            this.Load += new System.EventHandler(this.TasksForm_Load);
            this.gbxTasksHolder.ResumeLayout(false);
            this.gbxTasksHolder.PerformLayout();
            this.gbTaskDetailsHolder.ResumeLayout(false);
            this.gbTaskDetailsHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTasksHolder;
        private System.Windows.Forms.ListBox lbTasksList;
        private System.Windows.Forms.GroupBox gbTaskDetailsHolder;
        private System.Windows.Forms.TextBox txtNewTaskName;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTaskDuration;
        private System.Windows.Forms.ListBox lbTaskEventsHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStartNewEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.ToolTip infoToolTip;
    }
}