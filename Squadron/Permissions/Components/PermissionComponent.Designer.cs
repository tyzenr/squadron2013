namespace SquadronAddIns.Default.Permissions.Components
{
    partial class PermissionComponent
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
            this.FooterPanel = new Windows8LookNFeel.Windows8Panel();
            this.box = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FooterPanel.Image = null;
            this.FooterPanel.Location = new System.Drawing.Point(0, 363);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(574, 27);
            this.FooterPanel.TabIndex = 9;
            this.FooterPanel.Tag = ";";
            this.FooterPanel.Text = null;
            // 
            // box
            // 
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.box.FormattingEnabled = true;
            this.box.HorizontalScrollbar = true;
            this.box.Location = new System.Drawing.Point(0, 0);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(574, 363);
            this.box.TabIndex = 10;
            // 
            // PermissionComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.box);
            this.Controls.Add(this.FooterPanel);
            this.Name = "PermissionComponent";
            this.Size = new System.Drawing.Size(574, 390);
            this.ResumeLayout(false);

        }

        #endregion

        public Windows8LookNFeel.Windows8Panel FooterPanel;
        private System.Windows.Forms.CheckedListBox box;
    }
}
