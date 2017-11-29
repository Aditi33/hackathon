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
            this.GetCoverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetCoverage
            // 
            this.GetCoverage.Location = new System.Drawing.Point(59, 32);
            this.GetCoverage.Name = "GetCoverage";
            this.GetCoverage.Size = new System.Drawing.Size(75, 23);
            this.GetCoverage.TabIndex = 0;
            this.GetCoverage.Text = "btnGetCoverage";
            this.GetCoverage.UseVisualStyleBackColor = true;
            this.GetCoverage.Click += new System.EventHandler(this.GetCoverage_Click);
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.GetCoverage);
            this.Name = "ToolForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetCoverage;
    }
}

