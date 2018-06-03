using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessLogger
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        Form1 form = new Form1();

        public void Settings_Load(object sender, EventArgs e)
        {
            IntervalBox.Text = form.RefreshTimer.Interval.ToString();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.RefreshTimer.Interval = int.Parse(IntervalBox.Text);
        }
    }
}
