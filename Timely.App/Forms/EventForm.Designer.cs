namespace Timely.App.Forms
{
    partial class EventForm
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
            this.EventTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDetailedTime = new System.Windows.Forms.Label();
            this.btnResumeEvent = new System.Windows.Forms.Button();
            this.btnStopEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventTimer
            // 
            this.EventTimer.Interval = 10;
            this.EventTimer.Tick += new System.EventHandler(this.EventTimer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(10);
            this.lblTime.Size = new System.Drawing.Size(404, 60);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00 : 00 : 00 : 00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetailedTime
            // 
            this.lblDetailedTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetailedTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailedTime.Location = new System.Drawing.Point(12, 67);
            this.lblDetailedTime.Name = "lblDetailedTime";
            this.lblDetailedTime.Padding = new System.Windows.Forms.Padding(5);
            this.lblDetailedTime.Size = new System.Drawing.Size(404, 29);
            this.lblDetailedTime.TabIndex = 2;
            this.lblDetailedTime.Text = "00 : 00 : 00 : 00";
            this.lblDetailedTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnResumeEvent
            // 
            this.btnResumeEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResumeEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.btnResumeEvent.BackgroundImage = global::Timely.App.Properties.Resources.appbar_timer_resume;
            this.btnResumeEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResumeEvent.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnResumeEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumeEvent.Location = new System.Drawing.Point(240, 113);
            this.btnResumeEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnResumeEvent.Name = "btnResumeEvent";
            this.btnResumeEvent.Size = new System.Drawing.Size(35, 35);
            this.btnResumeEvent.TabIndex = 17;
            this.btnResumeEvent.UseVisualStyleBackColor = false;
            // 
            // btnStopEvent
            // 
            this.btnStopEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopEvent.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStopEvent.BackgroundImage = global::Timely.App.Properties.Resources.appbar_timer_stop;
            this.btnStopEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStopEvent.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnStopEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopEvent.Location = new System.Drawing.Point(197, 113);
            this.btnStopEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopEvent.Name = "btnStopEvent";
            this.btnStopEvent.Size = new System.Drawing.Size(35, 35);
            this.btnStopEvent.TabIndex = 16;
            this.btnStopEvent.UseVisualStyleBackColor = false;
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
            this.btnDeleteEvent.Location = new System.Drawing.Point(154, 113);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(35, 35);
            this.btnDeleteEvent.TabIndex = 15;
            this.btnDeleteEvent.UseVisualStyleBackColor = false;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 161);
            this.Controls.Add(this.btnResumeEvent);
            this.Controls.Add(this.btnStopEvent);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.lblDetailedTime);
            this.Controls.Add(this.lblTime);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(444, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(444, 200);
            this.Name = "EventForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Event";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer EventTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDetailedTime;
        private System.Windows.Forms.Button btnStopEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnResumeEvent;
    }
}