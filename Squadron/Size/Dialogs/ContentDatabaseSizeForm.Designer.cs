namespace SquadronAddIns.Default.Size.Dialogs
{
    partial class ContentDatabaseSizeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.grid);
            this.WorkareaPanel.Controls.Add(this.panel1);
            this.WorkareaPanel.Size = new System.Drawing.Size(703, 338);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(703, 45);
            this.HeaderPanel.Text = "Content Database Size Information";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Location = new System.Drawing.Point(0, 383);
            this.FooterPanel.Size = new System.Drawing.Size(703, 27);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(672, 15);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(622, 15);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 38);
            this.panel1.TabIndex = 16;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteButton.Image = null;
            this.ExecuteButton.Location = new System.Drawing.Point(1, 1);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(139, 37);
            this.ExecuteButton.TabIndex = 13;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Font = new System.Drawing.Font("Calibri", 10F);
            this.grid.Location = new System.Drawing.Point(0, 38);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 40;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(703, 300);
            this.grid.TabIndex = 22;
            // 
            // ContentDatabaseSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 410);
            this.HeaderText = "Content Database Size Information";
            this.Name = "ContentDatabaseSizeForm";
            this.ShowFooter = true;
            this.Text = "Content Database Size Information";
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private Windows8LookNFeel.Windows8GridView grid;
    }
}
