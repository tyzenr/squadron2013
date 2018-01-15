namespace Squadron.Widgets
{
    partial class WizardForm
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
            this.PreviousButton = new Windows8LookNFeel.Windows8Button();
            this.NextButton = new Windows8LookNFeel.Windows8Button();
            this.FinishButton = new Windows8LookNFeel.Windows8Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorkareaPanel.Controls.Add(this.tabControl1);
            this.WorkareaPanel.Size = new System.Drawing.Size(620, 339);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HeaderPanel.Text = "Wizard";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.FinishButton);
            this.FooterPanel.Controls.Add(this.NextButton);
            this.FooterPanel.Controls.Add(this.PreviousButton);
            this.FooterPanel.Location = new System.Drawing.Point(0, 384);
            this.FooterPanel.Size = new System.Drawing.Size(620, 41);
            this.FooterPanel.Controls.SetChildIndex(this.PreviousButton, 0);
            this.FooterPanel.Controls.SetChildIndex(this.NextButton, 0);
            this.FooterPanel.Controls.SetChildIndex(this.FinishButton, 0);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.PreviousButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PreviousButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PreviousButton.ForeColor = System.Drawing.Color.White;
            this.PreviousButton.Image = null;
            this.PreviousButton.Location = new System.Drawing.Point(289, 7);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(90, 28);
            this.PreviousButton.TabIndex = 0;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PreviousButton.Visible = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.NextButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NextButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Image = null;
            this.NextButton.Location = new System.Drawing.Point(380, 7);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(90, 28);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NextButton.Visible = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.FinishButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FinishButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FinishButton.ForeColor = System.Drawing.Color.White;
            this.FinishButton.Image = null;
            this.FinishButton.Location = new System.Drawing.Point(524, 7);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(90, 28);
            this.FinishButton.TabIndex = 1;
            this.FinishButton.Text = "Finish";
            this.FinishButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinishButton.Visible = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 337);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stylingWorkarea1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea1.Location = new System.Drawing.Point(3, 3);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(604, 305);
            this.stylingWorkarea1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 425);
            this.HeaderText = "Wizard";
            this.Name = "WizardForm";
            this.ShowFooter = true;
            this.Text = "Wizard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WizardForm_KeyDown);
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        public Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage2;
        public Windows8LookNFeel.Windows8Button FinishButton;
        public Windows8LookNFeel.Windows8Button NextButton;
        public Windows8LookNFeel.Windows8Button PreviousButton;
    }
}
