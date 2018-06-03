namespace ProcessLogger
{
    partial class TaskExecuter
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
            this.label1 = new System.Windows.Forms.Label();
            this.FileDir = new System.Windows.Forms.TextBox();
            this.ProcessSelectDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectDirBtn = new System.Windows.Forms.Button();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Arg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "프로세스 경로:";
            // 
            // FileDir
            // 
            this.FileDir.Location = new System.Drawing.Point(108, 10);
            this.FileDir.Name = "FileDir";
            this.FileDir.Size = new System.Drawing.Size(143, 21);
            this.FileDir.TabIndex = 1;
            // 
            // SelectDirBtn
            // 
            this.SelectDirBtn.Location = new System.Drawing.Point(257, 8);
            this.SelectDirBtn.Name = "SelectDirBtn";
            this.SelectDirBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectDirBtn.TabIndex = 2;
            this.SelectDirBtn.Text = "탐색...";
            this.SelectDirBtn.UseVisualStyleBackColor = true;
            this.SelectDirBtn.Click += new System.EventHandler(this.SelectDirBtn_Click);
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(338, 8);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(75, 23);
            this.ExecuteBtn.TabIndex = 4;
            this.ExecuteBtn.Text = "실행";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "인수:";
            // 
            // Arg
            // 
            this.Arg.Location = new System.Drawing.Point(108, 36);
            this.Arg.Name = "Arg";
            this.Arg.Size = new System.Drawing.Size(143, 21);
            this.Arg.TabIndex = 6;
            // 
            // TaskExecuter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 67);
            this.Controls.Add(this.Arg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.SelectDirBtn);
            this.Controls.Add(this.FileDir);
            this.Controls.Add(this.label1);
            this.Name = "TaskExecuter";
            this.Text = "TaskExecuter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileDir;
        private System.Windows.Forms.OpenFileDialog ProcessSelectDialog;
        private System.Windows.Forms.Button SelectDirBtn;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Arg;
    }
}