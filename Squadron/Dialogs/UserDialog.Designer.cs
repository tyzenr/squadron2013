using Windows8LookNFeel;
namespace Squadron.Dialogs
{
    partial class UserDialog
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
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.FindButton = new Windows8LookNFeel.Windows8Button();
            this.NameText = new System.Windows.Forms.TextBox();
            this.list = new Windows8LookNFeel.Windows8ListBox();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.stylingWorkarea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.list);
            this.WorkareaPanel.Controls.Add(this.stylingWorkarea1);
            this.WorkareaPanel.Location = new System.Drawing.Point(0, 28);
            this.WorkareaPanel.Size = new System.Drawing.Size(345, 370);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Chartreuse;
            this.HeaderPanel.Caption = "Users";
            this.HeaderPanel.Size = new System.Drawing.Size(345, 28);
            this.HeaderPanel.Text = "Users";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FooterPanel.Size = new System.Drawing.Size(345, 27);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(46, 5);
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Caption = null;
            this.stylingWorkarea1.Controls.Add(this.FindButton);
            this.stylingWorkarea1.Controls.Add(this.NameText);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingWorkarea1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea1.HasBorder = true;
            this.stylingWorkarea1.Image = null;
            this.stylingWorkarea1.IsImageTransparent = false;
            this.stylingWorkarea1.Location = new System.Drawing.Point(0, 0);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(345, 33);
            this.stylingWorkarea1.TabIndex = 0;
            this.stylingWorkarea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.FindButton.Caption = "Find";
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindButton.Description = null;
            this.FindButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FindButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.HasBorder = true;
            this.FindButton.HasRightSideBorder = false;
            this.FindButton.Image = null;
            this.FindButton.Is2PaneDrawing = false;
            this.FindButton.IsImageTransparent = false;
            this.FindButton.IsMouseOn = false;
            this.FindButton.IsRadio = false;
            this.FindButton.Location = new System.Drawing.Point(259, 3);
            this.FindButton.Name = "FindButton";
            this.FindButton.ShowDescriptionOnHover = true;
            this.FindButton.Size = new System.Drawing.Size(83, 26);
            this.FindButton.TabIndex = 18;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(4, 4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(253, 25);
            this.NameText.TabIndex = 17;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.WhiteSmoke;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.list.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 32;
            this.list.Location = new System.Drawing.Point(0, 33);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(345, 337);
            this.list.TabIndex = 8;
            this.list.DoubleClick += new System.EventHandler(this.list_DoubleClick);
            // 
            // UserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 425);
            this.HeaderText = "Users";
            this.Name = "UserDialog";
            this.ShowFooter = true;
            this.Text = "Users";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserDialog_KeyDown);
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.stylingWorkarea1.ResumeLayout(false);
            this.stylingWorkarea1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8ListBox list;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private Windows8LookNFeel.Windows8Button FindButton;
        public System.Windows.Forms.TextBox NameText;

    }
}
