namespace Squadron.Components
{
    partial class ScopeControl
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
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.WebApplicationRadio = new System.Windows.Forms.RadioButton();
            this.SiteCollectionRadio = new System.Windows.Forms.RadioButton();
            this.SiteRadio = new System.Windows.Forms.RadioButton();
            this.stylingWorkarea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Controls.Add(this.SiteRadio);
            this.stylingWorkarea1.Controls.Add(this.SiteCollectionRadio);
            this.stylingWorkarea1.Controls.Add(this.WebApplicationRadio);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea1.Location = new System.Drawing.Point(0, 0);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(299, 30);
            this.stylingWorkarea1.TabIndex = 0;
            // 
            // WebApplicationRadio
            // 
            this.WebApplicationRadio.AutoSize = true;
            this.WebApplicationRadio.Checked = true;
            this.WebApplicationRadio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebApplicationRadio.Location = new System.Drawing.Point(6, 3);
            this.WebApplicationRadio.Name = "WebApplicationRadio";
            this.WebApplicationRadio.Size = new System.Drawing.Size(122, 21);
            this.WebApplicationRadio.TabIndex = 0;
            this.WebApplicationRadio.TabStop = true;
            this.WebApplicationRadio.Text = "Web Application";
            this.WebApplicationRadio.UseVisualStyleBackColor = true;
            // 
            // SiteCollectionRadio
            // 
            this.SiteCollectionRadio.AutoSize = true;
            this.SiteCollectionRadio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteCollectionRadio.Location = new System.Drawing.Point(134, 3);
            this.SiteCollectionRadio.Name = "SiteCollectionRadio";
            this.SiteCollectionRadio.Size = new System.Drawing.Size(108, 21);
            this.SiteCollectionRadio.TabIndex = 0;
            this.SiteCollectionRadio.Text = "Site Collection";
            this.SiteCollectionRadio.UseVisualStyleBackColor = true;
            // 
            // SiteRadio
            // 
            this.SiteRadio.AutoSize = true;
            this.SiteRadio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteRadio.Location = new System.Drawing.Point(248, 3);
            this.SiteRadio.Name = "SiteRadio";
            this.SiteRadio.Size = new System.Drawing.Size(47, 21);
            this.SiteRadio.TabIndex = 0;
            this.SiteRadio.Text = "Site";
            this.SiteRadio.UseVisualStyleBackColor = true;
            // 
            // ScopeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stylingWorkarea1);
            this.Name = "ScopeControl";
            this.Size = new System.Drawing.Size(299, 30);
            this.stylingWorkarea1.ResumeLayout(false);
            this.stylingWorkarea1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private System.Windows.Forms.RadioButton WebApplicationRadio;
        private System.Windows.Forms.RadioButton SiteRadio;
        private System.Windows.Forms.RadioButton SiteCollectionRadio;
    }
}
