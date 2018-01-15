namespace SquadronAddins.Default.CopyItems
{
    partial class CopyItemControl
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
            this.SourceLabel = new System.Windows.Forms.Label();
            this.DestinationText = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceLabel
            // 
            this.SourceLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceLabel.ForeColor = System.Drawing.Color.Navy;
            this.SourceLabel.Location = new System.Drawing.Point(3, 3);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(194, 23);
            this.SourceLabel.TabIndex = 0;
            this.SourceLabel.Text = "Source List";
            // 
            // DestinationText
            // 
            this.DestinationText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationText.Location = new System.Drawing.Point(203, 1);
            this.DestinationText.Name = "DestinationText";
            this.DestinationText.Size = new System.Drawing.Size(215, 22);
            this.DestinationText.TabIndex = 1;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.Navy;
            this.InfoLabel.Location = new System.Drawing.Point(424, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(158, 27);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "Info";
            // 
            // CopyItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.DestinationText);
            this.Controls.Add(this.SourceLabel);
            this.Name = "CopyItemControl";
            this.Size = new System.Drawing.Size(610, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.TextBox DestinationText;
        private System.Windows.Forms.Label InfoLabel;
    }
}
