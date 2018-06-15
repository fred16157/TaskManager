namespace ProcessLogger
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleAdderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRemoteAddrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.TaskListBox = new System.Windows.Forms.ListBox();
            this.ScheduleListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScheduleCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.LogBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TrackerCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.Refresh_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LastUpdatedTimeLabel = new System.Windows.Forms.Label();
            this.ProcessKill_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RemoteInpectorTgtComboBox = new System.Windows.Forms.ComboBox();
            this.RemoteInpectorCheckBox = new System.Windows.Forms.CheckBox();
            this.Host_Btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsMenuItem,
            this.RunToolStripMenuItem,
            this.TrackMenuItem,
            this.ScheduleAdderToolStripMenuItem,
            this.AddRemoteAddrToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(43, 20);
            this.MenuStrip.Text = "메뉴";
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SettingsMenuItem.Text = "설정";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // RunToolStripMenuItem
            // 
            this.RunToolStripMenuItem.Name = "RunToolStripMenuItem";
            this.RunToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.RunToolStripMenuItem.Text = "실행 ";
            this.RunToolStripMenuItem.Click += new System.EventHandler(this.RunToolStripMenuItem_Click);
            // 
            // TrackMenuItem
            // 
            this.TrackMenuItem.Name = "TrackMenuItem";
            this.TrackMenuItem.Size = new System.Drawing.Size(154, 22);
            this.TrackMenuItem.Text = "트래킹";
            this.TrackMenuItem.Click += new System.EventHandler(this.TrackMenuItem_Click);
            // 
            // ScheduleAdderToolStripMenuItem
            // 
            this.ScheduleAdderToolStripMenuItem.Name = "ScheduleAdderToolStripMenuItem";
            this.ScheduleAdderToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ScheduleAdderToolStripMenuItem.Text = "스케쥴 추가";
            this.ScheduleAdderToolStripMenuItem.Click += new System.EventHandler(this.ScheduleAdderToolStripMenuItem_Click);
            // 
            // AddRemoteAddrToolStripMenuItem
            // 
            this.AddRemoteAddrToolStripMenuItem.Name = "AddRemoteAddrToolStripMenuItem";
            this.AddRemoteAddrToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AddRemoteAddrToolStripMenuItem.Text = "원격 주소 추가";
            this.AddRemoteAddrToolStripMenuItem.Click += new System.EventHandler(this.AddRemoteAddrToolStripMenuItem_Click);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 50;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // TaskListBox
            // 
            this.TaskListBox.FormattingEnabled = true;
            this.TaskListBox.ItemHeight = 12;
            this.TaskListBox.Location = new System.Drawing.Point(12, 92);
            this.TaskListBox.Name = "TaskListBox";
            this.TaskListBox.Size = new System.Drawing.Size(369, 352);
            this.TaskListBox.TabIndex = 2;
            this.TaskListBox.SelectedValueChanged += new System.EventHandler(this.TaskListBox_SelectedValueChanged);
            // 
            // ScheduleListBox
            // 
            this.ScheduleListBox.FormattingEnabled = true;
            this.ScheduleListBox.ItemHeight = 12;
            this.ScheduleListBox.Location = new System.Drawing.Point(387, 44);
            this.ScheduleListBox.Name = "ScheduleListBox";
            this.ScheduleListBox.Size = new System.Drawing.Size(400, 184);
            this.ScheduleListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "프로세스 목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "스케줄";
            // 
            // ScheduleCheckTimer
            // 
            this.ScheduleCheckTimer.Enabled = true;
            this.ScheduleCheckTimer.Interval = 1000;
            this.ScheduleCheckTimer.Tick += new System.EventHandler(this.ScheduleCheckTimer_Tick);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(387, 246);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(401, 198);
            this.LogBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "로그:";
            // 
            // TrackerCheckTimer
            // 
            this.TrackerCheckTimer.Enabled = true;
            this.TrackerCheckTimer.Tick += new System.EventHandler(this.TrackerCheckTimer_Tick);
            // 
            // Refresh_Btn
            // 
            this.Refresh_Btn.Location = new System.Drawing.Point(100, 49);
            this.Refresh_Btn.Name = "Refresh_Btn";
            this.Refresh_Btn.Size = new System.Drawing.Size(75, 23);
            this.Refresh_Btn.TabIndex = 8;
            this.Refresh_Btn.Text = "새로고침";
            this.Refresh_Btn.UseVisualStyleBackColor = true;
            this.Refresh_Btn.Click += new System.EventHandler(this.Refresh_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "마지막 새로고침:";
            // 
            // LastUpdatedTimeLabel
            // 
            this.LastUpdatedTimeLabel.AutoSize = true;
            this.LastUpdatedTimeLabel.Location = new System.Drawing.Point(116, 77);
            this.LastUpdatedTimeLabel.Name = "LastUpdatedTimeLabel";
            this.LastUpdatedTimeLabel.Size = new System.Drawing.Size(131, 12);
            this.LastUpdatedTimeLabel.TabIndex = 10;
            this.LastUpdatedTimeLabel.Text = "(마지막 새로고침 시간)";
            // 
            // ProcessKill_Btn
            // 
            this.ProcessKill_Btn.Enabled = false;
            this.ProcessKill_Btn.Location = new System.Drawing.Point(181, 49);
            this.ProcessKill_Btn.Name = "ProcessKill_Btn";
            this.ProcessKill_Btn.Size = new System.Drawing.Size(92, 23);
            this.ProcessKill_Btn.TabIndex = 11;
            this.ProcessKill_Btn.Text = "프로세스 종료";
            this.ProcessKill_Btn.UseVisualStyleBackColor = true;
            this.ProcessKill_Btn.Click += new System.EventHandler(this.ProcessKill_Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "대상:";
            // 
            // RemoteInpectorTgtComboBox
            // 
            this.RemoteInpectorTgtComboBox.Enabled = false;
            this.RemoteInpectorTgtComboBox.FormattingEnabled = true;
            this.RemoteInpectorTgtComboBox.Items.AddRange(new object[] {
            "(로컬 컴퓨터)"});
            this.RemoteInpectorTgtComboBox.Location = new System.Drawing.Point(54, 26);
            this.RemoteInpectorTgtComboBox.Name = "RemoteInpectorTgtComboBox";
            this.RemoteInpectorTgtComboBox.Size = new System.Drawing.Size(169, 20);
            this.RemoteInpectorTgtComboBox.TabIndex = 14;
            // 
            // RemoteInpectorCheckBox
            // 
            this.RemoteInpectorCheckBox.AutoSize = true;
            this.RemoteInpectorCheckBox.Location = new System.Drawing.Point(229, 30);
            this.RemoteInpectorCheckBox.Name = "RemoteInpectorCheckBox";
            this.RemoteInpectorCheckBox.Size = new System.Drawing.Size(152, 16);
            this.RemoteInpectorCheckBox.TabIndex = 15;
            this.RemoteInpectorCheckBox.Text = "원격 프로세스 가져오기";
            this.RemoteInpectorCheckBox.UseVisualStyleBackColor = true;
            this.RemoteInpectorCheckBox.CheckedChanged += new System.EventHandler(this.RemoteInpectorCheckBox_CheckedChanged);
            // 
            // Host_Btn
            // 
            this.Host_Btn.Location = new System.Drawing.Point(279, 49);
            this.Host_Btn.Name = "Host_Btn";
            this.Host_Btn.Size = new System.Drawing.Size(75, 23);
            this.Host_Btn.TabIndex = 16;
            this.Host_Btn.Text = "호스트";
            this.Host_Btn.UseVisualStyleBackColor = true;
            this.Host_Btn.Click += new System.EventHandler(this.Host_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Host_Btn);
            this.Controls.Add(this.RemoteInpectorCheckBox);
            this.Controls.Add(this.RemoteInpectorTgtComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProcessKill_Btn);
            this.Controls.Add(this.LastUpdatedTimeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Refresh_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScheduleListBox);
            this.Controls.Add(this.TaskListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrackMenuItem;
        public System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.ListBox TaskListBox;
        private System.Windows.Forms.ToolStripMenuItem ScheduleAdderToolStripMenuItem;
        public System.Windows.Forms.ListBox ScheduleListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer ScheduleCheckTimer;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer TrackerCheckTimer;
        private System.Windows.Forms.Button Refresh_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LastUpdatedTimeLabel;
        private System.Windows.Forms.Button ProcessKill_Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox RemoteInpectorTgtComboBox;
        private System.Windows.Forms.CheckBox RemoteInpectorCheckBox;
        private System.Windows.Forms.ToolStripMenuItem AddRemoteAddrToolStripMenuItem;
        private System.Windows.Forms.Button Host_Btn;
    }
}

