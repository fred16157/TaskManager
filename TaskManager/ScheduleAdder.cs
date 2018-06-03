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
    public partial class ScheduleAdder : Form
    {
        public class ProcInfo
        {
            public string TargetDir { get; set; }
            public string Arg { get; set; }
            public DateTime ScheduledTime { get; set; }
            public ProcInfo(string TargetDir, string Arg, DateTime ScheduledTime)
            {
                this.TargetDir = TargetDir;
                this.Arg = Arg;
                this.ScheduledTime = ScheduledTime;
            }
            public override string ToString()
            {
                return this.TargetDir + " 인수: " + this.Arg + " 예약 시간: " + ScheduledTime.ToShortDateString() +" " +this.ScheduledTime.ToShortTimeString();
            }
        }
        Form1 form;
        public static List<ProcInfo> ScheduleList = new List<ProcInfo>();
        public ScheduleAdder(Form1 form1) 
        {
            form = form1;
            InitializeComponent();
        }

        private void FindDir_Btn_Click(object sender, EventArgs e)
        {
            if(FileFinderDialog.ShowDialog() == DialogResult.OK)
            {
                TargetDirBox.Text = FileFinderDialog.FileName;
            }
        }

        private void Execute_Btn_Click(object sender, EventArgs e)
        {
            ScheduleList.Add(new ProcInfo(@TargetDirBox.Text , ArgBox.Text , ScheduleTimePicker.Value));

            form.ScheduleListBox.Items.Clear();
            foreach (ProcInfo procInfo in ScheduleList)
            {
                //form.ScheduleListBox.Items.Add(procInfo.TargetDir + " 인수: " + procInfo.Arg + " 예약 시간: " + procInfo.ScheduledTime);
                form.ScheduleListBox.Items.Add(procInfo.ToString());
            }
        }

        private void ScheduleTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
