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
    public partial class ProcDetails : Form
    {
        TaskTracker.Tracker tracker;
        public ProcDetails(TaskTracker.Tracker tracker)
        {
            this.tracker = tracker;
            InitializeComponent();
        }

        private void ProcDetails_Load(object sender, EventArgs e)
        {
            LogListBox.Items.Add(tracker.RelatedLogs);
            ProcNameLabel.Text = tracker.ProcName;
            if(tracker.IsValid == false)
            {
                ProcStatusLabel.Text = "이 프로세스는 유효하지 않습니다";
            }
            else if(tracker.IsResponding == false)
            {
                ProcStatusLabel.Text = "이 프로세스는 응답하고 있지 않습니다";
            }
            else
            {
                ProcStatusLabel.Text = "이 프로세스는 정상 작동중입니다";
            }
            PagedMemoryUsageLabel.Text = (tracker.Proc.PagedMemorySize64 / 1024.0 / 1024.0 ).ToString() + "MB";
            MemoryUsageLabel.Text = (tracker.Proc.WorkingSet64 / 1024.0 / 1024.0).ToString() + "MB";
            VirtualMemoryUsageLabel.Text = (tracker.Proc.VirtualMemorySize64 / 1024.0 / 1024.0).ToString() + "MB";
            ThreadsCountLabel.Text =  tracker.Proc.Threads.Count.ToString();
        }
        
    }
}
