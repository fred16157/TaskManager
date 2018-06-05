namespace ProcessLogger
{
    partial class ProcDetails
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
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProcNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcStatusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PagedMemoryUsageLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ThreadsCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MemoryUsageLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.VirtualMemoryUsageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogListBox
            // 
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.ItemHeight = 12;
            this.LogListBox.Location = new System.Drawing.Point(313, 31);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(349, 364);
            this.LogListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "프로세스에 관한 로그:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "다음 프로그램의 상세 정보:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "이름:";
            // 
            // ProcNameLabel
            // 
            this.ProcNameLabel.AutoSize = true;
            this.ProcNameLabel.Location = new System.Drawing.Point(52, 31);
            this.ProcNameLabel.Name = "ProcNameLabel";
            this.ProcNameLabel.Size = new System.Drawing.Size(91, 12);
            this.ProcNameLabel.TabIndex = 4;
            this.ProcNameLabel.Text = "(프로세스 이름)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "상태:";
            // 
            // ProcStatusLabel
            // 
            this.ProcStatusLabel.AutoSize = true;
            this.ProcStatusLabel.Location = new System.Drawing.Point(52, 47);
            this.ProcStatusLabel.Name = "ProcStatusLabel";
            this.ProcStatusLabel.Size = new System.Drawing.Size(91, 12);
            this.ProcStatusLabel.TabIndex = 6;
            this.ProcStatusLabel.Text = "(프로세스 상태)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "페이징된 메모리 사용량:";
            // 
            // PagedMemoryUsageLabel
            // 
            this.PagedMemoryUsageLabel.AutoSize = true;
            this.PagedMemoryUsageLabel.Location = new System.Drawing.Point(158, 63);
            this.PagedMemoryUsageLabel.Name = "PagedMemoryUsageLabel";
            this.PagedMemoryUsageLabel.Size = new System.Drawing.Size(91, 12);
            this.PagedMemoryUsageLabel.TabIndex = 8;
            this.PagedMemoryUsageLabel.Text = "(메모리 사용량)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "실행중인 스레드 수:";
            // 
            // ThreadsCountLabel
            // 
            this.ThreadsCountLabel.AutoSize = true;
            this.ThreadsCountLabel.Location = new System.Drawing.Point(131, 117);
            this.ThreadsCountLabel.Name = "ThreadsCountLabel";
            this.ThreadsCountLabel.Size = new System.Drawing.Size(67, 12);
            this.ThreadsCountLabel.TabIndex = 10;
            this.ThreadsCountLabel.Text = "(스레드 수)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "실제 메모리 사용량:";
            // 
            // MemoryUsageLabel
            // 
            this.MemoryUsageLabel.AutoSize = true;
            this.MemoryUsageLabel.Location = new System.Drawing.Point(130, 79);
            this.MemoryUsageLabel.Name = "MemoryUsageLabel";
            this.MemoryUsageLabel.Size = new System.Drawing.Size(119, 12);
            this.MemoryUsageLabel.TabIndex = 12;
            this.MemoryUsageLabel.Text = "(실제 메모리 사용량)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "가상 메모리 사용량:";
            // 
            // VirtualMemoryUsageLabel
            // 
            this.VirtualMemoryUsageLabel.AutoSize = true;
            this.VirtualMemoryUsageLabel.Location = new System.Drawing.Point(130, 95);
            this.VirtualMemoryUsageLabel.Name = "VirtualMemoryUsageLabel";
            this.VirtualMemoryUsageLabel.Size = new System.Drawing.Size(119, 12);
            this.VirtualMemoryUsageLabel.TabIndex = 14;
            this.VirtualMemoryUsageLabel.Text = "(가상 메모리 사용량)";
            // 
            // ProcDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 412);
            this.Controls.Add(this.VirtualMemoryUsageLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MemoryUsageLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ThreadsCountLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PagedMemoryUsageLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProcStatusLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProcNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogListBox);
            this.Name = "ProcDetails";
            this.Text = "ProcDetails";
            this.Load += new System.EventHandler(this.ProcDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProcNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProcStatusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PagedMemoryUsageLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ThreadsCountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label MemoryUsageLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label VirtualMemoryUsageLabel;
    }
}