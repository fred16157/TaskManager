using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessLogger
{
    public partial class AddRemoteTarget : Form
    {
        Form1 form1;
        public AddRemoteTarget(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            form1.RemoteInpectorTgtComboBox.Items.Add(AddrBox.Text);
        }
    }
}
