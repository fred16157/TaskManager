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
    public partial class TaskExecuter : Form
    {
        public TaskExecuter()
        {
            InitializeComponent();
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ProcessInfo = new ProcessStartInfo(@FileDir.Text, Arg.Text);
            Process.Start(ProcessInfo);
        }

        private void SelectDirBtn_Click(object sender, EventArgs e)
        {
            if(ProcessSelectDialog.ShowDialog() == DialogResult.OK)
            {
                FileDir.Text = ProcessSelectDialog.FileName;
            }
        }
    }
}
