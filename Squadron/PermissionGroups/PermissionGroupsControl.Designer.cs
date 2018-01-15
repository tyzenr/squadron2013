namespace SquadronAddIns.Default.PermissionGroups
{
    partial class PermissionGroupsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrossSiteCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowUserName = new Windows8LookNFeel.Windows8CheckBox();
            this.IncludeUsersCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 32);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(560, 307);
            this.grid.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CrossSiteCheck);
            this.panel1.Controls.Add(this.ShowUserName);
            this.panel1.Controls.Add(this.IncludeUsersCheck);
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 32);
            this.panel1.TabIndex = 13;
            // 
            // CrossSiteCheck
            // 
            this.CrossSiteCheck.AutoSize = true;
            this.CrossSiteCheck.BackColor = System.Drawing.Color.Transparent;
            this.CrossSiteCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossSiteCheck.Location = new System.Drawing.Point(156, 7);
            this.CrossSiteCheck.Name = "CrossSiteCheck";
            this.CrossSiteCheck.Size = new System.Drawing.Size(134, 19);
            this.CrossSiteCheck.TabIndex = 14;
            this.CrossSiteCheck.Text = "Cross Site Collection";
            this.CrossSiteCheck.UseVisualStyleBackColor = false;
            // 
            // ShowUserName
            // 
            this.ShowUserName.AutoSize = true;
            this.ShowUserName.BackColor = System.Drawing.Color.Transparent;
            this.ShowUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUserName.Location = new System.Drawing.Point(396, 7);
            this.ShowUserName.Name = "ShowUserName";
            this.ShowUserName.Size = new System.Drawing.Size(116, 19);
            this.ShowUserName.TabIndex = 14;
            this.ShowUserName.Text = "Show User Name";
            this.ShowUserName.UseVisualStyleBackColor = false;
            this.ShowUserName.Visible = false;
            // 
            // IncludeUsersCheck
            // 
            this.IncludeUsersCheck.AutoSize = true;
            this.IncludeUsersCheck.BackColor = System.Drawing.Color.Transparent;
            this.IncludeUsersCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeUsersCheck.Location = new System.Drawing.Point(294, 7);
            this.IncludeUsersCheck.Name = "IncludeUsersCheck";
            this.IncludeUsersCheck.Size = new System.Drawing.Size(96, 19);
            this.IncludeUsersCheck.TabIndex = 14;
            this.IncludeUsersCheck.Text = "Include Users";
            this.IncludeUsersCheck.UseVisualStyleBackColor = false;
            this.IncludeUsersCheck.CheckedChanged += new System.EventHandler(this.IncludeUsersCheck_CheckedChanged);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteButton.Image = null;
            this.ExecuteButton.Location = new System.Drawing.Point(0, 0);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(148, 32);
            this.ExecuteButton.TabIndex = 13;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // PermissionGroupsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "PermissionGroupsControl";
            this.Size = new System.Drawing.Size(560, 339);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8CheckBox IncludeUsersCheck;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private Windows8LookNFeel.Windows8CheckBox CrossSiteCheck;
        private Windows8LookNFeel.Windows8CheckBox ShowUserName;
    }
}
