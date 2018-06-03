namespace ProcessLogger
{
    partial class TaskTracker
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
            this.TrackerList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackTgtBox = new System.Windows.Forms.TextBox();
            this.FindProc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrackerList
            // 
            this.TrackerList.FormattingEnabled = true;
            this.TrackerList.ItemHeight = 12;
            this.TrackerList.Location = new System.Drawing.Point(13, 13);
            this.TrackerList.Name = "TrackerList";
            this.TrackerList.Size = new System.Drawing.Size(389, 424);
            this.TrackerList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "트래킹 대상(PID):";
            // 
            // TrackTgtBox
            // 
            this.TrackTgtBox.Location = new System.Drawing.Point(516, 15);
            this.TrackTgtBox.Name = "TrackTgtBox";
            this.TrackTgtBox.Size = new System.Drawing.Size(191, 21);
            this.TrackTgtBox.TabIndex = 2;
            // 
            // FindProc
            // 
            this.FindProc.Location = new System.Drawing.Point(713, 15);
            this.FindProc.Name = "FindProc";
            this.FindProc.Size = new System.Drawing.Size(75, 23);
            this.FindProc.TabIndex = 3;
            this.FindProc.Text = "추가";
            this.FindProc.UseVisualStyleBackColor = true;
            this.FindProc.Click += new System.EventHandler(this.FindProc_Click);
            // 
            // TaskTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FindProc);
            this.Controls.Add(this.TrackTgtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackerList);
            this.Name = "TaskTracker";
            this.Text = "TaskTracker";
            this.Load += new System.EventHandler(this.TaskTracker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TrackerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TrackTgtBox;
        private System.Windows.Forms.Button FindProc;
    }
}