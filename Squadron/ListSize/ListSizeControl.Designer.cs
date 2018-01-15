namespace SquadronAddins.Default.SiteSize
{
    partial class SiteSizeControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ListCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.DocLibCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.CalculateButton = new Windows8LookNFeel.Windows8Button();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.ListCheck);
            this.panel1.Controls.Add(this.DocLibCheck);
            this.panel1.Controls.Add(this.CalculateButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 32);
            this.panel1.TabIndex = 0;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(436, 8);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 17);
            this.TotalLabel.TabIndex = 15;
            this.TotalLabel.Text = "Total:";
            // 
            // ListCheck
            // 
            this.ListCheck.AutoSize = true;
            this.ListCheck.BackColor = System.Drawing.Color.Transparent;
            this.ListCheck.Checked = true;
            this.ListCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ListCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCheck.Location = new System.Drawing.Point(281, 8);
            this.ListCheck.Name = "ListCheck";
            this.ListCheck.Size = new System.Drawing.Size(44, 19);
            this.ListCheck.TabIndex = 14;
            this.ListCheck.Text = "List";
            this.ListCheck.UseVisualStyleBackColor = false;
            // 
            // DocLibCheck
            // 
            this.DocLibCheck.AutoSize = true;
            this.DocLibCheck.BackColor = System.Drawing.Color.Transparent;
            this.DocLibCheck.Checked = true;
            this.DocLibCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DocLibCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocLibCheck.Location = new System.Drawing.Point(155, 8);
            this.DocLibCheck.Name = "DocLibCheck";
            this.DocLibCheck.Size = new System.Drawing.Size(121, 19);
            this.DocLibCheck.TabIndex = 14;
            this.DocLibCheck.Text = "Document Library";
            this.DocLibCheck.UseVisualStyleBackColor = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.CalculateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Image = null;
            this.CalculateButton.Location = new System.Drawing.Point(2, 2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(144, 28);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "Execute";
            this.CalculateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 32);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(636, 402);
            this.grid.TabIndex = 12;
            // 
            // SiteSizeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "SiteSizeControl";
            this.Size = new System.Drawing.Size(636, 434);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid;
        private Windows8LookNFeel.Windows8Button CalculateButton;
        private System.Windows.Forms.Label TotalLabel;
        private Windows8LookNFeel.Windows8CheckBox ListCheck;
        private Windows8LookNFeel.Windows8CheckBox DocLibCheck;
    }
}
