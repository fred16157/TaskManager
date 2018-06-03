namespace ProcessLogger
{
    partial class ScheduleAdder
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
            this.label2 = new System.Windows.Forms.Label();
            this.TargetDirBox = new System.Windows.Forms.TextBox();
            this.FindDir_Btn = new System.Windows.Forms.Button();
            this.Execute_Btn = new System.Windows.Forms.Button();
            this.ArgBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FileFinderDialog = new System.Windows.Forms.OpenFileDialog();
            this.ScheduleTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "실행 대상:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "인수:";
            // 
            // TargetDirBox
            // 
            this.TargetDirBox.Location = new System.Drawing.Point(80, 10);
            this.TargetDirBox.Name = "TargetDirBox";
            this.TargetDirBox.Size = new System.Drawing.Size(215, 21);
            this.TargetDirBox.TabIndex = 2;
            // 
            // FindDir_Btn
            // 
            this.FindDir_Btn.Location = new System.Drawing.Point(301, 8);
            this.FindDir_Btn.Name = "FindDir_Btn";
            this.FindDir_Btn.Size = new System.Drawing.Size(75, 23);
            this.FindDir_Btn.TabIndex = 3;
            this.FindDir_Btn.Text = "찾기";
            this.FindDir_Btn.UseVisualStyleBackColor = true;
            this.FindDir_Btn.Click += new System.EventHandler(this.FindDir_Btn_Click);
            // 
            // Execute_Btn
            // 
            this.Execute_Btn.Location = new System.Drawing.Point(379, 8);
            this.Execute_Btn.Name = "Execute_Btn";
            this.Execute_Btn.Size = new System.Drawing.Size(75, 23);
            this.Execute_Btn.TabIndex = 4;
            this.Execute_Btn.Text = "실행";
            this.Execute_Btn.UseVisualStyleBackColor = true;
            this.Execute_Btn.Click += new System.EventHandler(this.Execute_Btn_Click);
            // 
            // ArgBox
            // 
            this.ArgBox.Location = new System.Drawing.Point(80, 35);
            this.ArgBox.Name = "ArgBox";
            this.ArgBox.Size = new System.Drawing.Size(215, 21);
            this.ArgBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "예약 시간:";
            // 
            // ScheduleTimePicker
            // 
            this.ScheduleTimePicker.CustomFormat = "yyyy-MM-dd tt hh:mm";
            this.ScheduleTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ScheduleTimePicker.Location = new System.Drawing.Point(80, 62);
            this.ScheduleTimePicker.Name = "ScheduleTimePicker";
            this.ScheduleTimePicker.Size = new System.Drawing.Size(215, 21);
            this.ScheduleTimePicker.TabIndex = 8;
            this.ScheduleTimePicker.ValueChanged += new System.EventHandler(this.ScheduleTimePicker_ValueChanged);
            // 
            // ScheduleAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 92);
            this.Controls.Add(this.ScheduleTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArgBox);
            this.Controls.Add(this.Execute_Btn);
            this.Controls.Add(this.FindDir_Btn);
            this.Controls.Add(this.TargetDirBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleAdder";
            this.Text = "ScheduleAdder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TargetDirBox;
        private System.Windows.Forms.Button FindDir_Btn;
        private System.Windows.Forms.Button Execute_Btn;
        private System.Windows.Forms.TextBox ArgBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog FileFinderDialog;
        private System.Windows.Forms.DateTimePicker ScheduleTimePicker;
    }
}