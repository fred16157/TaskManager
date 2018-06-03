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

namespace ProcessLogger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Process Proc in Process.GetProcesses())
            {
                TaskListBox.Items.Add(Proc.ProcessName +" | " +  Proc.Id.ToString());
            }
            TaskListBox.Sorted = true;
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void RunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskExecuter taskExecuter = new TaskExecuter();
            taskExecuter.ShowDialog();
        }

        private void TrackMenuItem_Click(object sender, EventArgs e)
        {
            TaskTracker taskTracker = new TaskTracker();
            taskTracker.ShowDialog();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
        //    TaskListBox.Items.Clear();
        //    foreach (Process Proc in Process.GetProcesses())
        //    {

        //        TaskListBox.Items.Add(Proc.ProcessName + " | " + Proc.Id.ToString());
        //    }
        }

        

        private void ScheduleAdderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleAdder scheduleAdder = new ScheduleAdder(this);
            scheduleAdder.ShowDialog();
        }

        private void ScheduleCheckTimer_Tick(object sender, EventArgs e)
        {
            foreach(ScheduleAdder.ProcInfo procInfo in ScheduleAdder.ScheduleList)
            {
                if(procInfo.ScheduledTime <= DateTime.Now)
                {
                    Process.Start(@procInfo.TargetDir, procInfo.Arg);
                    ScheduleAdder.ScheduleList.Remove(procInfo);
                    ScheduleListBox.Items.Remove(procInfo.ToString());
                    break;
                }
            }
        }

        private void TrackerCheckTimer_Tick(object sender, EventArgs e)
        {
            foreach (TaskTracker.Tracker tracker in TaskTracker.ProcList)
            {
                if(tracker.Proc.HasExited)
                {
                    LogBox.AppendText("다음 프로그램이 닫힘: " + tracker.ProcName + " | " + tracker.ProcId + "\n");
                    TaskTracker.ProcList.Remove(tracker);
                    break;
                }
                else if (!tracker.Proc.Responding && tracker.IsResponding)
                {
                    LogBox.AppendText("다음 프로세스의 응답이 없음: " + tracker.ProcName + " | " + tracker.ProcId + "\n");
                    tracker.IsResponding = false;
                    break;
                }
                else if(tracker.Proc.Responding && !tracker.IsResponding)
                {
                    LogBox.AppendText("다음 프로세스의 응답이 돌아옴: " + tracker.ProcName + " | " + tracker.ProcId + "\n");
                    tracker.IsResponding = true;
                    break;
                }
            }
        }
        

        private void Refresh_Btn_Click(object sender, EventArgs e)
        {
            TaskListBox.Items.Clear();
            foreach (Process Proc in Process.GetProcesses())
            {
                TaskListBox.Items.Add(Proc.ProcessName + " | " + Proc.Id.ToString());
            }
        }
    }
}
