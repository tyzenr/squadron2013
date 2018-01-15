namespace Squadron.Animation
{
    partial class AnimationForm
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
            this.stylingPanel1 = new Windows8LookNFeel.Windows8Panel();
            this.pbr = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stylingPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stylingPanel1
            // 
            this.stylingPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.stylingPanel1.Controls.Add(this.pbr);
            this.stylingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingPanel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingPanel1.Image = null;
            this.stylingPanel1.Location = new System.Drawing.Point(0, 0);
            this.stylingPanel1.Name = "stylingPanel1";
            this.stylingPanel1.Size = new System.Drawing.Size(271, 41);
            this.stylingPanel1.TabIndex = 0;
            // 
            // pbr
            // 
            this.pbr.Location = new System.Drawing.Point(12, 12);
            this.pbr.Name = "pbr";
            this.pbr.Size = new System.Drawing.Size(247, 16);
            this.pbr.TabIndex = 0;
            this.pbr.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(271, 41);
            this.Controls.Add(this.stylingPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busy ";
            this.stylingPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Panel stylingPanel1;
        private System.Windows.Forms.ProgressBar pbr;
        private System.Windows.Forms.Timer timer1;

    }
}
