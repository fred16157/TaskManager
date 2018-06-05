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
    public partial class TaskTracker : Form
    {
        public class Tracker
        {
            static public bool operator == (Tracker Left, Tracker Right)
            {
                if(Left.ProcId == Right.ProcId)
                {
                    return true;
                }
                return false;
            }
            static public bool operator !=(Tracker Left, Tracker Right)
            {
                if (Left.ProcId != Right.ProcId)
                {
                    return true;
                }
                return false;
            }
            public Process Proc
            {
                get; set;
            }
            public bool IsResponding
            {
                get; set;
            }
            public bool IsValid
            {
                get; set;
            }
            public string ProcName
            {
                get; set;
            }
            public int ProcId
            {
                get; set;
            }
            public List<string> RelatedLogs
            {
                get; set;
            }
            public Tracker(Process Proc, bool IsResponding)
            {
                this.Proc = Proc;
                this.IsResponding = IsResponding;
                IsValid = true;
                ProcName = Proc.ProcessName;
                ProcId = Proc.Id;
                RelatedLogs = new List<string>();
            }
        }
        public static List<Tracker> ProcList = new List<Tracker>();
        public TaskTracker()
        {
            InitializeComponent();
        }

        private void FindProc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TrackTgtBox.Text, out int Pid))
            {
                try
                {
                    if(Process.GetProcessById(Pid).HasExited)
                    {
                        MessageBox.Show("입력한 값에 맞는 프로세스를 찾지 못했습니다");
                    }
                    else if(Process.GetProcessById(Pid).Responding)
                    {
                        TrackerList.Items.Add(Process.GetProcessById(Pid).ProcessName + " | " + Process.GetProcessById(Pid).Id + " | 정상");
                        ProcList.Add(new Tracker(Process.GetProcessById(Pid), true));
                    }
                    else if(!Process.GetProcessById(Pid).Responding)
                    {
                        TrackerList.Items.Add(Process.GetProcessById(Pid).ProcessName + " | " + Process.GetProcessById(Pid).Id + " | 응답 없음");
                        ProcList.Add(new Tracker(Process.GetProcessById(Pid), false));
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("프로세스를 찾지 못했습니다: " + Ex.StackTrace, "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("입력한 값이 PID가 아닙니다");
            }
        }

        private void TaskTracker_Load(object sender, EventArgs e)
        {
            TrackerList.Items.Clear();
            foreach (Tracker tracker in ProcList)
            {   if(tracker.Proc.Responding)
                {
                    TrackerList.Items.Add(tracker.Proc.ProcessName + " | " + tracker.Proc.Id + " | " + "정상");
                }
                else if(!tracker.Proc.Responding)
                {
                    TrackerList.Items.Add(tracker.Proc.ProcessName + " | " + tracker.Proc.Id + " | " + "응답 없음");
                }
            }
        }

        private void TrackerList_SelectedValueChanged(object sender, EventArgs e)
        {
            ViewDetails_Btn.Enabled = true;
        }

        private void ViewDetails_Btn_Click(object sender, EventArgs e)
        {
            var v = int.Parse(TrackerList.SelectedItem.ToString().Split(' ')[2]);
            Process proc;
            try
            {
                proc = Process.GetProcessById(v);
                Tracker tempTracker;

                tempTracker = new Tracker(proc, proc.Responding);

                foreach (Tracker tracker in ProcList)
                {
                    if (tracker == tempTracker)
                    {
                        ProcDetails procDetails = new ProcDetails(tempTracker);
                        procDetails.ShowDialog();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("프로세스를 찾지 못했습니다: " + Ex.StackTrace);
            }
        }

        private void Refresh_Btn_Click(object sender, EventArgs e)
        {
            TrackerList.Items.Clear();
            foreach (Tracker tracker in ProcList)
            {
                if (tracker.Proc.Responding)
                {
                    TrackerList.Items.Add(tracker.Proc.ProcessName + " | " + tracker.Proc.Id + " | " + "정상");
                }
                else if (!tracker.Proc.Responding)
                {
                    TrackerList.Items.Add(tracker.Proc.ProcessName + " | " + tracker.Proc.Id + " | " + "응답 없음");
                }
            }
        }
    }
}
