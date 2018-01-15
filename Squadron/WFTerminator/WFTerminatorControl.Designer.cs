namespace SquadronAddins.Default.WFTerminator
{
    partial class WFTerminatorControl
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
            this.InternalStateList = new System.Windows.Forms.ComboBox();
            this.TerminateButton = new Windows8LookNFeel.Windows8Button();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InternalStateList);
            this.panel1.Controls.Add(this.TerminateButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 32);
            this.panel1.TabIndex = 13;
            // 
            // InternalStateList
            // 
            this.InternalStateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InternalStateList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternalStateList.FormattingEnabled = true;
            this.InternalStateList.Location = new System.Drawing.Point(3, 2);
            this.InternalStateList.Name = "InternalStateList";
            this.InternalStateList.Size = new System.Drawing.Size(261, 28);
            this.InternalStateList.TabIndex = 14;
            this.InternalStateList.SelectedIndexChanged += new System.EventHandler(this.InternalStateList_SelectedIndexChanged);
            // 
            // TerminateButton
            // 
            this.TerminateButton.Caption = "Terminate";
            this.TerminateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TerminateButton.Description = null;
            this.TerminateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TerminateButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.TerminateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminateButton.HasBorder = true;
            this.TerminateButton.HasRightSideBorder = false;
            this.TerminateButton.Image = null;
            this.TerminateButton.Is2PaneDrawing = false;
            this.TerminateButton.IsImageTransparent = false;
            this.TerminateButton.IsMouseOn = false;
            this.TerminateButton.IsRadio = false;
            this.TerminateButton.Location = new System.Drawing.Point(267, 0);
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.ShowDescriptionOnHover = true;
            this.TerminateButton.Size = new System.Drawing.Size(148, 32);
            this.TerminateButton.TabIndex = 13;
            this.TerminateButton.Text = "Terminate";
            this.TerminateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TerminateButton.Click += new System.EventHandler(this.TerminateButton_Click);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
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
            this.grid.Location = new System.Drawing.Point(0, 32);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.NoSelectedColor = false;
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(682, 385);
            this.grid.TabIndex = 17;
            // 
            // WFTerminatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "WFTerminatorControl";
            this.Size = new System.Drawing.Size(682, 417);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8Button TerminateButton;
        private System.Windows.Forms.ComboBox InternalStateList;
        private Windows8LookNFeel.Windows8GridView grid;
    }
}
