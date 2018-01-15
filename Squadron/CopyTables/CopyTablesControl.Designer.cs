namespace Squadron.Addins.SqlServer.CopyTables
{
    partial class CopyTablesControl
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
            this.CopyButton = new Windows8LookNFeel.Windows8Button();
            this.SourceButton = new Windows8LookNFeel.Windows8Button();
            this.DestButton = new Windows8LookNFeel.Windows8Button();
            this.lst1 = new System.Windows.Forms.CheckedListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.pbr = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.CopyButton.Caption = "Copy";
            this.tableLayoutPanel1.SetColumnSpan(this.CopyButton, 2);
            this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyButton.Description = null;
            this.CopyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CopyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CopyButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.CopyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.ForeColor = System.Drawing.Color.White;
            this.CopyButton.HasBorder = true;
            this.CopyButton.HasRightSideBorder = false;
            this.CopyButton.Image = null;
            this.CopyButton.Is2PaneDrawing = false;
            this.CopyButton.IsImageTransparent = false;
            this.CopyButton.IsMouseOn = false;
            this.CopyButton.IsRadio = false;
            this.CopyButton.Location = new System.Drawing.Point(3, 395);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.ShowDescriptionOnHover = true;
            this.CopyButton.Size = new System.Drawing.Size(652, 43);
            this.CopyButton.TabIndex = 17;
            this.CopyButton.Text = "Start Copying";
            this.CopyButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SourceButton
            // 
            this.SourceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.SourceButton.Caption = "Source";
            this.SourceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SourceButton.Description = null;
            this.SourceButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SourceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.SourceButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceButton.ForeColor = System.Drawing.Color.White;
            this.SourceButton.HasBorder = true;
            this.SourceButton.HasRightSideBorder = false;
            this.SourceButton.Image = null;
            this.SourceButton.Is2PaneDrawing = false;
            this.SourceButton.IsImageTransparent = false;
            this.SourceButton.IsMouseOn = false;
            this.SourceButton.IsRadio = false;
            this.SourceButton.Location = new System.Drawing.Point(3, 3);
            this.SourceButton.Name = "SourceButton";
            this.SourceButton.ShowDescriptionOnHover = true;
            this.SourceButton.Size = new System.Drawing.Size(323, 43);
            this.SourceButton.TabIndex = 17;
            this.SourceButton.Text = "Source Connect";
            this.SourceButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SourceButton.Click += new System.EventHandler(this.SourceButton_Click);
            // 
            // DestButton
            // 
            this.DestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.DestButton.Caption = "Destination";
            this.DestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DestButton.Description = null;
            this.DestButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DestButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.DestButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestButton.ForeColor = System.Drawing.Color.White;
            this.DestButton.HasBorder = true;
            this.DestButton.HasRightSideBorder = false;
            this.DestButton.Image = null;
            this.DestButton.Is2PaneDrawing = false;
            this.DestButton.IsImageTransparent = false;
            this.DestButton.IsMouseOn = false;
            this.DestButton.IsRadio = false;
            this.DestButton.Location = new System.Drawing.Point(332, 3);
            this.DestButton.Name = "DestButton";
            this.DestButton.ShowDescriptionOnHover = true;
            this.DestButton.Size = new System.Drawing.Size(323, 43);
            this.DestButton.TabIndex = 17;
            this.DestButton.Text = "Destination Connect";
            this.DestButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DestButton.Click += new System.EventHandler(this.DestButton_Click);
            // 
            // lst1
            // 
            this.lst1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(3, 52);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(323, 337);
            this.lst1.TabIndex = 18;
            // 
            // lst2
            // 
            this.lst2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lst2.FormattingEnabled = true;
            this.lst2.ItemHeight = 17;
            this.lst2.Location = new System.Drawing.Point(332, 52);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(323, 337);
            this.lst2.TabIndex = 20;
            // 
            // pbr
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pbr, 2);
            this.pbr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbr.Location = new System.Drawing.Point(3, 444);
            this.pbr.MaximumSize = new System.Drawing.Size(0, 10);
            this.pbr.Name = "pbr";
            this.pbr.Size = new System.Drawing.Size(652, 10);
            this.pbr.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SourceButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbr, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DestButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CopyButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lst2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lst1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 490);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // CopyTablesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CopyTablesControl";
            this.Size = new System.Drawing.Size(658, 490);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Button CopyButton;
        private Windows8LookNFeel.Windows8Button SourceButton;
        private Windows8LookNFeel.Windows8Button DestButton;
        private System.Windows.Forms.CheckedListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.ProgressBar pbr;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
