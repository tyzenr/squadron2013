namespace SquadronAddIns.Default.Command.Dialogs
{
    partial class EnsureUserDialog
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
            this.components = new System.ComponentModel.Container();
            this.WebList = new System.Windows.Forms.CheckedListBox();
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.UsersText = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.stylingWorkarea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.stylingWorkarea1);
            this.WorkareaPanel.Controls.Add(this.WebList);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HeaderPanel.Text = "Ensure User";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FooterPanel.Text = "Please select the websites & enter the user names";
            // 
            // HelpButton
            // 
            this.HelpButton.LaunchUrl = "http://www.jeanpaulva.com/?p=4988";
            // 
            // WebList
            // 
            this.WebList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WebList.Dock = System.Windows.Forms.DockStyle.Top;
            this.WebList.FormattingEnabled = true;
            this.WebList.Location = new System.Drawing.Point(0, 0);
            this.WebList.Name = "WebList";
            this.WebList.Size = new System.Drawing.Size(620, 77);
            this.WebList.TabIndex = 1;
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Controls.Add(this.UsersText);
            this.stylingWorkarea1.Controls.Add(this.ExecuteButton);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea1.Location = new System.Drawing.Point(0, 77);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(620, 276);
            this.stylingWorkarea1.TabIndex = 2;
            // 
            // UsersText
            // 
            this.UsersText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsersText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersText.Location = new System.Drawing.Point(0, 0);
            this.UsersText.Multiline = true;
            this.UsersText.Name = "UsersText";
            this.UsersText.Size = new System.Drawing.Size(620, 238);
            this.UsersText.TabIndex = 1;
            this.UsersText.Text = "DOMAIN\\User1\r\nDOMAIN\\User2\r\n";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ExecuteButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteButton.Image = null;
            this.ExecuteButton.Location = new System.Drawing.Point(0, 238);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(620, 38);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.ExecuteButton, "Users will be added to all selected Web objects");
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // EnsureUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 425);
            this.HeaderText = "Ensure User";
            this.Name = "EnsureUserDialog";
            this.ShowFooter = true;
            this.Text = "Ensure User";
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.stylingWorkarea1.ResumeLayout(false);
            this.stylingWorkarea1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private System.Windows.Forms.TextBox UsersText;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private System.Windows.Forms.CheckedListBox WebList;
        private System.Windows.Forms.ToolTip toolTip1;


    }
}
