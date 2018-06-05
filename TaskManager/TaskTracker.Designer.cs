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
            this.label2 = new System.Windows.Forms.Label();
            this.ViewDetails_Btn = new System.Windows.Forms.Button();
            this.Refresh_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrackerList
            // 
            this.TrackerList.FormattingEnabled = true;
            this.TrackerList.ItemHeight = 12;
            this.TrackerList.Location = new System.Drawing.Point(13, 37);
            this.TrackerList.Name = "TrackerList";
            this.TrackerList.Size = new System.Drawing.Size(389, 400);
            this.TrackerList.TabIndex = 0;
            this.TrackerList.SelectedValueChanged += new System.EventHandler(this.TrackerList_SelectedValueChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "트래킹중인 프로세스 목록";
            // 
            // ViewDetails_Btn
            // 
            this.ViewDetails_Btn.Enabled = false;
            this.ViewDetails_Btn.Location = new System.Drawing.Point(164, 7);
            this.ViewDetails_Btn.Name = "ViewDetails_Btn";
            this.ViewDetails_Btn.Size = new System.Drawing.Size(89, 23);
            this.ViewDetails_Btn.TabIndex = 5;
            this.ViewDetails_Btn.Text = "자세히 보기";
            this.ViewDetails_Btn.UseMnemonic = false;
            this.ViewDetails_Btn.UseVisualStyleBackColor = true;
            this.ViewDetails_Btn.Click += new System.EventHandler(this.ViewDetails_Btn_Click);
            // 
            // Refresh_Btn
            // 
            this.Refresh_Btn.Location = new System.Drawing.Point(259, 8);
            this.Refresh_Btn.Name = "Refresh_Btn";
            this.Refresh_Btn.Size = new System.Drawing.Size(75, 23);
            this.Refresh_Btn.TabIndex = 6;
            this.Refresh_Btn.Text = "새로고침";
            this.Refresh_Btn.UseVisualStyleBackColor = true;
            this.Refresh_Btn.Click += new System.EventHandler(this.Refresh_Btn_Click);
            // 
            // TaskTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Refresh_Btn);
            this.Controls.Add(this.ViewDetails_Btn);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewDetails_Btn;
        private System.Windows.Forms.Button Refresh_Btn;
    }
}