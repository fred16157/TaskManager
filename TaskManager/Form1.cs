using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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

        Process process;
        Socket Listener;
        List<IPAddress> WhiteList = new List<IPAddress>();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Process Proc in Process.GetProcesses())
            {
                TaskListBox.Items.Add(Proc.ProcessName +" | " +  Proc.Id.ToString());
            }
            LastUpdatedTimeLabel.Text = DateTime.Now.ToString();
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
            if (process != null)
            {
                try
                {
                    if (!process.Responding)
                    {
                        TaskListBox.Items.Clear();
                        foreach (Process Proc in Process.GetProcesses())
                        {
                            TaskListBox.Items.Add(Proc.ProcessName + " | " + Proc.Id.ToString());
                        }
                        LastUpdatedTimeLabel.Text = DateTime.Now.ToString();
                        process = null;
                        RefreshTimer.Enabled = false;
                    }
                }
                catch
                {
                    TaskListBox.Items.Clear();
                    foreach (Process Proc in Process.GetProcesses())
                    {
                        TaskListBox.Items.Add(Proc.ProcessName + " | " + Proc.Id.ToString());
                    }
                    LastUpdatedTimeLabel.Text = DateTime.Now.ToString();
                    process = null;
                    RefreshTimer.Enabled = false;
                }
            }
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
                if(tracker.Proc.HasExited && tracker.IsValid)
                {
                    Log("다음 프로세스가 닫힘: " + tracker.ProcName + " | " + tracker.ProcId + "\n");
                    TaskTracker.ProcList.Remove(tracker);
                    break;
                }
                else if (!tracker.Proc.Responding && tracker.IsResponding)
                {
                    Log("다음 프로세스의 응답이 없음: " + tracker.ProcName + " | " + tracker.ProcId + "\n");
                    tracker.RelatedLogs.Add(DateTime.Now + "다음 프로세스의 응답이 없음: " + tracker.ProcName + " | " + tracker.ProcId + "\n");
                    tracker.IsResponding = false;
                    break;
                }
                else if(tracker.Proc.Responding && !tracker.IsResponding)
                {
                    Log("다음 프로세스의 응답이 돌아옴: " + tracker.ProcName + " | " + tracker.ProcId + "\n");
                    tracker.RelatedLogs.Add(DateTime.Now + "다음 프로세스의 응답이 돌아옴: " + tracker.ProcName + " | " + tracker.ProcId + "\n");
                    tracker.IsResponding = true;
                    break;
                }
            }
        }
        

        private void Refresh_Btn_Click(object sender, EventArgs e)
        {
            if(RemoteInpectorTgtComboBox.SelectedItem == null)
            {
                TaskListBox.Items.Clear();
                foreach (Process Proc in Process.GetProcesses())
                {
                    TaskListBox.Items.Add(Proc.ProcessName + " | " + Proc.Id.ToString());
                }
                LastUpdatedTimeLabel.Text = DateTime.Now.ToString();
                return;
            }
            if(RemoteInpectorCheckBox.Checked)
            {
                if (RemoteInpectorTgtComboBox.SelectedItem.ToString().CompareTo("(로컬 컴퓨터)") == 0)
                {
                    TaskListBox.Items.Clear();
                    foreach (Process Proc in Process.GetProcesses())
                    {
                        TaskListBox.Items.Add(Proc.ProcessName + " | " + Proc.Id.ToString());
                    }
                    LastUpdatedTimeLabel.Text = DateTime.Now.ToString();
                    return;
                }
                IPAddress RemoteAddr = IPAddress.Parse(RemoteInpectorTgtComboBox.SelectedItem.ToString());
                IPHostEntry He = Dns.GetHostEntry(Dns.GetHostName());

                IPEndPoint Ep = null;
                foreach (IPAddress HostAddr in He.AddressList)
                {
                    if(HostAddr.AddressFamily == AddressFamily.InterNetwork)
                    { 
                        Ep = new IPEndPoint(HostAddr, 17200);
                        break;
                    }
                }

                Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Client.Connect(Ep);
                Log("다음 위치에 클라이언트 생성됨: " + Ep.Address + " :17200");
                //byte[] Bytes = 
                //Client.Send();
                byte[] BufSiz = new byte[4];
                Client.Receive(BufSiz);
                byte[] Data = new byte[BitConverter.ToInt32(BufSiz, 0)];
                Client.Receive(Data);
                Client.Close();

                TaskListBox.Items.Clear();
                foreach (string ProcName in FromByteArray(Data))
                {
                    TaskListBox.Items.Add(ProcName);
                }
                LastUpdatedTimeLabel.Text = DateTime.Now.ToString();
            }
        }
        


        public void Log (string Msg)
        {
            LogBox.AppendText(DateTime.Now + " | " + Msg + "\n");
        }



        private void ProcessKill_Btn_Click(object sender, EventArgs e)
        {
            var v = int.Parse(TaskListBox.SelectedItem.ToString().Split(' ')[2]);
            try
            {
                process = Process.GetProcessById(v);
                Process.GetProcessById(v).Kill();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("프로세스를 찾지 못했습니다: " + Ex.StackTrace);
            }
            RefreshTimer.Enabled = true;
        }

        private void TaskListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ProcessKill_Btn.Enabled = true;
        }

        private void RemoteInpectorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(RemoteInpectorTgtComboBox.Enabled)
            {
                RemoteInpectorTgtComboBox.Enabled = false;
                return;
            }
            RemoteInpectorTgtComboBox.Enabled = true;
        }

        private void AddRemoteAddrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRemoteTarget addRemoteTarget = new AddRemoteTarget(this);
            addRemoteTarget.ShowDialog();
        }

        private void Host_Btn_Click(object sender, EventArgs e)
        {
            Host_Btn.Enabled = false;
            IPEndPoint Ep = null;
            IPHostEntry He = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress HostAddr in He.AddressList)
            {
                if (HostAddr.AddressFamily == AddressFamily.InterNetwork)
                {
                    Ep = new IPEndPoint(HostAddr, 17200);
                    break;
                }
            }
            Listener = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            Listener.Bind(Ep);
            Listener.Listen(5);
            Log("다음 위치에서 서버가 시작됨: " + Ep.Address + ":17200");
            ThreadStart Ts = new ThreadStart(StartListener);
            Thread Th = new Thread(Ts);
            Th.Start();
        }

        public void StartListener()
        {
            while(true)
            {
                Socket AccSock = Listener.Accept();

                if (WhiteList.Contains(IPAddress.Parse(AccSock.RemoteEndPoint.ToString().Split(':')[0])))
                {
                    AccSock.Close();
                    continue;
                }
                if (MessageBox.Show("다음 대상의 접속을 허용하시겠습니까? \n" + AccSock.RemoteEndPoint, "권한 부여", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    byte[] bufsiz = new byte[4];

                    List<string> ProcNameList = new List<string>();
                    foreach (Process Proc in Process.GetProcesses())
                    {
                        ProcNameList.Add(Proc.ProcessName + " | " + Proc.Id);
                    }
                    byte[] Data = ToByteArray(ProcNameList.ToArray());
                    bufsiz = BitConverter.GetBytes(Data.Count());
                    AccSock.Send(bufsiz);
                    AccSock.Send(Data);
                    WhiteList.Add(IPAddress.Parse(AccSock.RemoteEndPoint.ToString().Split(':')[0]));
                    AccSock.Close();
                }
                AccSock.Close();
            }
        }
        private static byte[] ToByteArray(string[] input)
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream, Encoding.UTF8))
            {
                var rows = input.GetLength(0);
                writer.Write(rows);
                for (int i = 0; i < rows; i++)
                {
                    writer.Write(input[i]);
                }

                writer.Flush();
                return stream.ToArray();
            }
        }

        private static string[] FromByteArray(byte[] input)
        {
            using (var stream = new MemoryStream(input))
            using (var reader = new BinaryReader(stream, Encoding.UTF8))
            {
                var rows = reader.ReadInt32();
                var result = new string[rows];
                for (int i = 0; i < rows; i++)
                {
                    result[i] = reader.ReadString();
                }
                return result;
            }
        }
    }
}
