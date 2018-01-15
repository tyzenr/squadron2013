namespace SquadronAddIns.Default.Permissions.Dialogs
{
    partial class FindDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDialog));
            this.stylingWorkarea3 = new Windows8LookNFeel.Windows8Panel();
            this.scope = new SquadronAddIns.Default.ScopeDropDownControl();
            this.UrlText = new System.Windows.Forms.TextBox();
            this.FindButton = new Windows8LookNFeel.Windows8Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.userPicture1 = new System.Windows.Forms.PictureBox();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.stylingWorkarea3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.grid);
            this.WorkareaPanel.Controls.Add(this.stylingWorkarea3);
            this.WorkareaPanel.Size = new System.Drawing.Size(518, 536);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(252)))), ((int)(((byte)(20)))));
            this.HeaderPanel.Size = new System.Drawing.Size(518, 45);
            this.HeaderPanel.Text = "Find Permissions";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FooterPanel.Location = new System.Drawing.Point(0, 581);
            this.FooterPanel.Size = new System.Drawing.Size(518, 27);
            this.FooterPanel.Text = "Enter user or group name to search for.  You can enter part of name too..";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(487, 15);
            // 
            // stylingWorkarea3
            // 
            this.stylingWorkarea3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea3.Controls.Add(this.scope);
            this.stylingWorkarea3.Controls.Add(this.UrlText);
            this.stylingWorkarea3.Controls.Add(this.FindButton);
            this.stylingWorkarea3.Controls.Add(this.NameText);
            this.stylingWorkarea3.Controls.Add(this.userPicture1);
            this.stylingWorkarea3.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingWorkarea3.Location = new System.Drawing.Point(0, 0);
            this.stylingWorkarea3.Name = "stylingWorkarea3";
            this.stylingWorkarea3.Size = new System.Drawing.Size(518, 70);
            this.stylingWorkarea3.TabIndex = 11;
            // 
            // scope
            // 
            this.scope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scope.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scope.FormattingEnabled = true;
            this.scope.Items.AddRange(new object[] {
            "Web Application",
            "Site Collection",
            "Site"});
            this.scope.Location = new System.Drawing.Point(4, 7);
            this.scope.Name = "scope";
            this.scope.Size = new System.Drawing.Size(127, 23);
            this.scope.TabIndex = 18;
            // 
            // UrlText
            // 
            this.UrlText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlText.Location = new System.Drawing.Point(137, 7);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(375, 25);
            this.UrlText.TabIndex = 17;
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.FindButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.Image = null;
            this.FindButton.Location = new System.Drawing.Point(427, 37);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(85, 26);
            this.FindButton.TabIndex = 16;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(45, 38);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(377, 25);
            this.NameText.TabIndex = 15;
            this.toolTip1.SetToolTip(this.NameText, "Enter User or Group name");
            // 
            // userPicture1
            // 
            this.userPicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPicture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPicture1.Image = ((System.Drawing.Image)(resources.GetObject("userPicture1.Image")));
            this.userPicture1.Location = new System.Drawing.Point(7, 37);
            this.userPicture1.Name = "userPicture1";
            this.userPicture1.Size = new System.Drawing.Size(30, 28);
            this.userPicture1.TabIndex = 3;
            this.userPicture1.TabStop = false;
            this.userPicture1.Click += new System.EventHandler(this.userPicture1_Click);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 70);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(518, 466);
            this.grid.TabIndex = 12;
            // 
            // FindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 608);
            this.HeaderText = "Find Permissions";
            this.Name = "FindDialog";
            this.ShowFooter = true;
            this.Text = "Find Permissions";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindDialog_KeyDown);
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.stylingWorkarea3.ResumeLayout(false);
            this.stylingWorkarea3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea3;
        private ScopeDropDownControl scope;
        public System.Windows.Forms.TextBox UrlText;
        private Windows8LookNFeel.Windows8Button FindButton;
        public System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.PictureBox userPicture1;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
