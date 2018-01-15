using Windows8LookNFeel;
namespace Squadron
{
    partial class ThemeForm
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
            this.stylingTitlePanel1 = new Squadron.Widgets.Section();
            this.stylingButton1 = new Windows8LookNFeel.Windows8Button();
            this.SuspendLayout();
            // 
            // stylingTitlePanel1
            // 
            this.stylingTitlePanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingTitlePanel1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stylingTitlePanel1.Location = new System.Drawing.Point(12, 120);
            this.stylingTitlePanel1.Name = "stylingTitlePanel1";
            this.stylingTitlePanel1.Size = new System.Drawing.Size(500, 205);
            this.stylingTitlePanel1.TabIndex = 0;
            this.stylingTitlePanel1.Text = "";
            // 
            // stylingButton1
            // 
            this.stylingButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.stylingButton1.Text = "";
            this.stylingButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingButton1.Image = null;
            this.stylingButton1.Location = new System.Drawing.Point(80, 12);
            this.stylingButton1.Name = "stylingButton1";
            this.stylingButton1.Size = new System.Drawing.Size(200, 100);
            this.stylingButton1.TabIndex = 1;
            this.stylingButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 337);
            this.Controls.Add(this.stylingButton1);
            this.Controls.Add(this.stylingTitlePanel1);
            this.Name = "ThemeForm";
            this.Text = "ThemeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Squadron.Widgets.Section stylingTitlePanel1;
        private Windows8Button stylingButton1;
    }
}
