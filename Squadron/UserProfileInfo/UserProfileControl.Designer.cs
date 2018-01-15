namespace SquadronAddins.Default.UserProfileInfo
{
    partial class UserProfileControl
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
            this.PerformButton = new Windows8LookNFeel.Windows8Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // PerformButton
            // 
            this.PerformButton.Caption = "Execute";
            this.PerformButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PerformButton.Description = null;
            this.PerformButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PerformButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.PerformButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerformButton.HasBorder = true;
            this.PerformButton.HasRightSideBorder = false;
            this.PerformButton.Image = null;
            this.PerformButton.Is2PaneDrawing = false;
            this.PerformButton.IsImageTransparent = false;
            this.PerformButton.IsMouseOn = false;
            this.PerformButton.IsRadio = false;
            this.PerformButton.Location = new System.Drawing.Point(0, 0);
            this.PerformButton.Name = "PerformButton";
            this.PerformButton.ShowDescriptionOnHover = true;
            this.PerformButton.Size = new System.Drawing.Size(148, 32);
            this.PerformButton.TabIndex = 0;
            this.PerformButton.Text = "Execute";
            this.PerformButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PerformButton.Click += new System.EventHandler(this.PerformButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PerformButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 33);
            this.panel1.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.CustomBackColor1 = System.Drawing.Color.Empty;
            this.grid.CustomBackColor2 = System.Drawing.Color.Empty;
            this.grid.CustomForecolor = System.Drawing.Color.Empty;
            this.grid.CustomSelectedBackColor1 = System.Drawing.Color.Empty;
            this.grid.CustomSelectedBackColor2 = System.Drawing.Color.Empty;
            this.grid.CustomSelectedForecolor = System.Drawing.Color.Empty;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.grid.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.grid.Location = new System.Drawing.Point(0, 33);
            this.grid.Name = "grid";
            this.grid.NoSelectedColor = false;
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(672, 339);
            this.grid.TabIndex = 4;
            // 
            // UserProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "UserProfileControl";
            this.Size = new System.Drawing.Size(672, 372);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Button PerformButton;
        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8GridView grid;


    }
}
