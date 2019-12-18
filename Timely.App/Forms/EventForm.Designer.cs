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
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(10);
            this.lblTime.Size = new System.Drawing.Size(404, 71);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00 : 00 : 00 : 00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetailedTime
            // 
            this.lblDetailedTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetailedTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailedTime.Location = new System.Drawing.Point(12, 80);
            this.lblDetailedTime.Name = "lblDetailedTime";
            this.lblDetailedTime.Padding = new System.Windows.Forms.Padding(5);
            this.lblDetailedTime.Size = new System.Drawing.Size(404, 29);
            this.lblDetailedTime.TabIndex = 2;
            this.lblDetailedTime.Text = "00 : 00 : 00 : 00";
            this.lblDetailedTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 127);
            this.Controls.Add(this.lblDetailedTime);
            this.Controls.Add(this.lblTime);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer EventTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDetailedTime;
    }
}