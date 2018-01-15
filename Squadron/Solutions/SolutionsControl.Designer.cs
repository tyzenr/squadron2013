using Windows8LookNFeel;
namespace SquadronAddIns.Default.Solutions
{
    partial class SolutionsControl
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new Windows8LookNFeel.Windows8Button();
            this.DeployButton = new Windows8LookNFeel.Windows8Button();
            this.RemoveButton = new Windows8LookNFeel.Windows8Button();
            this.ViewButton = new Windows8LookNFeel.Windows8Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.DeployButton);
            this.panel1.Controls.Add(this.RemoveButton);
            this.panel1.Controls.Add(this.ViewButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 38);
            this.panel1.TabIndex = 16;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Caption = "Delete";
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Description = null;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.HasBorder = true;
            this.DeleteButton.HasRightSideBorder = false;
            this.DeleteButton.Image = null;
            this.DeleteButton.Is2PaneDrawing = false;
            this.DeleteButton.IsImageTransparent = false;
            this.DeleteButton.IsMouseOn = false;
            this.DeleteButton.IsRadio = false;
            this.DeleteButton.Location = new System.Drawing.Point(396, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ShowDescriptionOnHover = true;
            this.DeleteButton.Size = new System.Drawing.Size(129, 32);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.DeleteButton, "Delete the Solution");
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeployButton
            // 
            this.DeployButton.Caption = "Deploy";
            this.DeployButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeployButton.Description = null;
            this.DeployButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeployButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.DeployButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeployButton.ForeColor = System.Drawing.Color.White;
            this.DeployButton.HasBorder = true;
            this.DeployButton.HasRightSideBorder = false;
            this.DeployButton.Image = null;
            this.DeployButton.Is2PaneDrawing = false;
            this.DeployButton.IsImageTransparent = false;
            this.DeployButton.IsMouseOn = false;
            this.DeployButton.IsRadio = false;
            this.DeployButton.Location = new System.Drawing.Point(133, 3);
            this.DeployButton.Name = "DeployButton";
            this.DeployButton.ShowDescriptionOnHover = true;
            this.DeployButton.Size = new System.Drawing.Size(129, 32);
            this.DeployButton.TabIndex = 19;
            this.DeployButton.Text = "Deploy";
            this.DeployButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.DeployButton, "Deploy Solution");
            this.DeployButton.Click += new System.EventHandler(this.DeployButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Caption = "Remove";
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.Description = null;
            this.RemoveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RemoveButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.HasBorder = true;
            this.RemoveButton.HasRightSideBorder = false;
            this.RemoveButton.Image = null;
            this.RemoveButton.Is2PaneDrawing = false;
            this.RemoveButton.IsImageTransparent = false;
            this.RemoveButton.IsMouseOn = false;
            this.RemoveButton.IsRadio = false;
            this.RemoveButton.Location = new System.Drawing.Point(264, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.ShowDescriptionOnHover = true;
            this.RemoveButton.Size = new System.Drawing.Size(129, 32);
            this.RemoveButton.TabIndex = 18;
            this.RemoveButton.Text = "Retract";
            this.RemoveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.RemoveButton, "Removes selected Solution");
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Caption = "Refresh";
            this.ViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewButton.Description = null;
            this.ViewButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ViewButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.ForeColor = System.Drawing.Color.White;
            this.ViewButton.HasBorder = true;
            this.ViewButton.HasRightSideBorder = false;
            this.ViewButton.Image = null;
            this.ViewButton.Is2PaneDrawing = false;
            this.ViewButton.IsImageTransparent = false;
            this.ViewButton.IsMouseOn = false;
            this.ViewButton.IsRadio = false;
            this.ViewButton.Location = new System.Drawing.Point(2, 3);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.ShowDescriptionOnHover = true;
            this.ViewButton.Size = new System.Drawing.Size(129, 32);
            this.ViewButton.TabIndex = 16;
            this.ViewButton.Text = "Refresh";
            this.ViewButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.ViewButton, "View all Solutions");
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.White;
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
            this.grid.Font = new System.Drawing.Font("Verdana", 9F);
            this.grid.Location = new System.Drawing.Point(0, 38);
            this.grid.Name = "grid";
            this.grid.NoSelectedColor = false;
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(562, 279);
            this.grid.TabIndex = 18;
            // 
            // OpenDialog
            // 
            this.OpenDialog.Filter = "*.wsp|*.wsp";
            // 
            // SolutionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "SolutionsControl";
            this.Size = new System.Drawing.Size(562, 317);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8Button ViewButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private Windows8LookNFeel.Windows8GridView grid;
        private Windows8LookNFeel.Windows8Button RemoveButton;
        private Windows8LookNFeel.Windows8Button DeployButton;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private Windows8LookNFeel.Windows8Button DeleteButton;
    }
}
