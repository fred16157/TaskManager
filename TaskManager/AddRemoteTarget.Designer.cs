namespace ProcessLogger
{
    partial class AddRemoteTarget
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
            this.AddrBox = new System.Windows.Forms.TextBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "원격 주소:";
            // 
            // AddrBox
            // 
            this.AddrBox.Location = new System.Drawing.Point(79, 9);
            this.AddrBox.Name = "AddrBox";
            this.AddrBox.Size = new System.Drawing.Size(199, 21);
            this.AddrBox.TabIndex = 1;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(284, 7);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Btn.TabIndex = 2;
            this.Add_Btn.Text = "추가";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // AddRemoteTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 40);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.AddrBox);
            this.Controls.Add(this.label1);
            this.Name = "AddRemoteTarget";
            this.Text = "AddRemoteTarget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddrBox;
        private System.Windows.Forms.Button Add_Btn;
    }
}