namespace Squadron.Others
{
    partial class LogForm
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
            this.LogBox = new System.Windows.Forms.ListBox();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.LogBox);
            this.WorkareaPanel.Size = new System.Drawing.Size(899, 454);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HeaderPanel.Size = new System.Drawing.Size(899, 45);
            this.HeaderPanel.Text = "Log";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Location = new System.Drawing.Point(0, 499);
            this.FooterPanel.Size = new System.Drawing.Size(899, 27);
            this.FooterPanel.Text = "Double click to view details.";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(868, 15);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(818, 15);
            // 
            // LogBox
            // 
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBox.ForeColor = System.Drawing.Color.Gray;
            this.LogBox.FormattingEnabled = true;
            this.LogBox.ItemHeight = 20;
            this.LogBox.Location = new System.Drawing.Point(0, 0);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(899, 454);
            this.LogBox.TabIndex = 16;
            this.LogBox.DoubleClick += new System.EventHandler(this.LogBox_DoubleClick);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 526);
            this.HeaderText = "Log";
            this.Name = "LogForm";
            this.ShowFooter = true;
            this.Text = "Log";
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox LogBox;
    }
}
