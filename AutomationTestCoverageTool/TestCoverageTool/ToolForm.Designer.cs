namespace TestCoverageTool
{
    partial class ToolForm
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
            this.btnGetCoverage = new System.Windows.Forms.Button();
            this.lblEnterExe = new System.Windows.Forms.Label();
            this.txtExePath = new System.Windows.Forms.TextBox();
            this.lblWorkingDir = new System.Windows.Forms.Label();
            this.txtWorkingDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetCoverage
            // 
            this.btnGetCoverage.Location = new System.Drawing.Point(103, 134);
            this.btnGetCoverage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetCoverage.Name = "btnGetCoverage";
            this.btnGetCoverage.Size = new System.Drawing.Size(104, 22);
            this.btnGetCoverage.TabIndex = 0;
            this.btnGetCoverage.Text = "GetCoverage";
            this.btnGetCoverage.UseVisualStyleBackColor = true;
            this.btnGetCoverage.Click += new System.EventHandler(this.GetCoverage_Click);
            // 
            // lblEnterExe
            // 
            this.lblEnterExe.AutoSize = true;
            this.lblEnterExe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEnterExe.Location = new System.Drawing.Point(26, 77);
            this.lblEnterExe.Name = "lblEnterExe";
            this.lblEnterExe.Size = new System.Drawing.Size(96, 13);
            this.lblEnterExe.TabIndex = 1;
            this.lblEnterExe.Text = "ExecutablePath";
            this.lblEnterExe.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtExePath
            // 
            this.txtExePath.Location = new System.Drawing.Point(139, 74);
            this.txtExePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExePath.Name = "txtExePath";
            this.txtExePath.Size = new System.Drawing.Size(152, 20);
            this.txtExePath.TabIndex = 2;
            // 
            // lblWorkingDir
            // 
            this.lblWorkingDir.AutoSize = true;
            this.lblWorkingDir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblWorkingDir.Location = new System.Drawing.Point(26, 33);
            this.lblWorkingDir.Name = "lblWorkingDir";
            this.lblWorkingDir.Size = new System.Drawing.Size(105, 13);
            this.lblWorkingDir.TabIndex = 3;
            this.lblWorkingDir.Text = "WorkingDirectory";
            // 
            // txtWorkingDir
            // 
            this.txtWorkingDir.Location = new System.Drawing.Point(139, 33);
            this.txtWorkingDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWorkingDir.Name = "txtWorkingDir";
            this.txtWorkingDir.Size = new System.Drawing.Size(152, 20);
            this.txtWorkingDir.TabIndex = 4;
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(325, 186);
            this.Controls.Add(this.txtWorkingDir);
            this.Controls.Add(this.lblWorkingDir);
            this.Controls.Add(this.txtExePath);
            this.Controls.Add(this.lblEnterExe);
            this.Controls.Add(this.btnGetCoverage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutomationCoverageTool";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCoverage;
        private System.Windows.Forms.Label lblEnterExe;
        private System.Windows.Forms.TextBox txtExePath;
        private System.Windows.Forms.Label lblWorkingDir;
        private System.Windows.Forms.TextBox txtWorkingDir;
    }
}

