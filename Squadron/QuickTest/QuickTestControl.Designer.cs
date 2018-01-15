namespace SquadronAddIns.Default.QuickTest
{
    partial class QuickTestControl
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
            this.TotalLabel = new System.Windows.Forms.Label();
            this.UrlText = new System.Windows.Forms.TextBox();
            this.CountText = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ThreadedTestButton = new Windows8LookNFeel.Windows8Button();
            this.AllDocumentsAndItemsCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.AllLibraryAndListCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.SubSiteCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.UrlOnlyCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusPanel = new Squadron.Widgets.StatusPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.ExceptionCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TestTypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stylingHeaderPanel1 = new Windows8LookNFeel.Windows8Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.stylingWorkarea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(1, 6);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(30, 17);
            this.TotalLabel.TabIndex = 18;
            this.TotalLabel.Text = "Url:";
            // 
            // UrlText
            // 
            this.UrlText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlText.Location = new System.Drawing.Point(3, 25);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(330, 25);
            this.UrlText.TabIndex = 17;
            this.toolTip1.SetToolTip(this.UrlText, "Enter the URL of site/library/list/document/item.  Current User credentials will " +
        "be used. ");
            // 
            // CountText
            // 
            this.CountText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CountText.Location = new System.Drawing.Point(337, 25);
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(74, 25);
            this.CountText.TabIndex = 20;
            this.toolTip1.SetToolTip(this.CountText, "Repeat Count for Requests");
            this.CountText.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "No. of Tests";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ThreadedTestButton);
            this.panel1.Controls.Add(this.AllDocumentsAndItemsCheck);
            this.panel1.Controls.Add(this.AllLibraryAndListCheck);
            this.panel1.Controls.Add(this.SubSiteCheck);
            this.panel1.Controls.Add(this.UrlOnlyCheck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CountText);
            this.panel1.Controls.Add(this.UrlText);
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 79);
            this.panel1.TabIndex = 24;
            // 
            // ThreadedTestButton
            // 
            this.ThreadedTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreadedTestButton.BackColor = System.Drawing.Color.White;
            this.ThreadedTestButton.Caption = "Threaded Test";
            this.ThreadedTestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThreadedTestButton.Description = null;
            this.ThreadedTestButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ThreadedTestButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.ThreadedTestButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadedTestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ThreadedTestButton.HasBorder = true;
            this.ThreadedTestButton.HasRightSideBorder = false;
            this.ThreadedTestButton.Image = null;
            this.ThreadedTestButton.Is2PaneDrawing = false;
            this.ThreadedTestButton.IsImageTransparent = false;
            this.ThreadedTestButton.IsMouseOn = false;
            this.ThreadedTestButton.IsRadio = false;
            this.ThreadedTestButton.Location = new System.Drawing.Point(519, 6);
            this.ThreadedTestButton.Name = "ThreadedTestButton";
            this.ThreadedTestButton.ShowDescriptionOnHover = true;
            this.ThreadedTestButton.Size = new System.Drawing.Size(119, 45);
            this.ThreadedTestButton.TabIndex = 25;
            this.ThreadedTestButton.Tag = "";
            this.ThreadedTestButton.Text = "Threaded Test";
            this.ThreadedTestButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThreadedTestButton.Click += new System.EventHandler(this.ThreadedTestButton_Click);
            // 
            // AllDocumentsAndItemsCheck
            // 
            this.AllDocumentsAndItemsCheck.AutoSize = true;
            this.AllDocumentsAndItemsCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AllDocumentsAndItemsCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.AllDocumentsAndItemsCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AllDocumentsAndItemsCheck.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.AllDocumentsAndItemsCheck.Location = new System.Drawing.Point(404, 55);
            this.AllDocumentsAndItemsCheck.Name = "AllDocumentsAndItemsCheck";
            this.AllDocumentsAndItemsCheck.Size = new System.Drawing.Size(167, 23);
            this.AllDocumentsAndItemsCheck.TabIndex = 24;
            this.AllDocumentsAndItemsCheck.Text = "All documents && items";
            this.toolTip1.SetToolTip(this.AllDocumentsAndItemsCheck, "All document & item urls will be tested");
            this.AllDocumentsAndItemsCheck.UseVisualStyleBackColor = false;
            this.AllDocumentsAndItemsCheck.Visible = false;
            // 
            // AllLibraryAndListCheck
            // 
            this.AllLibraryAndListCheck.AutoSize = true;
            this.AllLibraryAndListCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AllLibraryAndListCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.AllLibraryAndListCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AllLibraryAndListCheck.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.AllLibraryAndListCheck.Location = new System.Drawing.Point(262, 55);
            this.AllLibraryAndListCheck.Name = "AllLibraryAndListCheck";
            this.AllLibraryAndListCheck.Size = new System.Drawing.Size(136, 23);
            this.AllLibraryAndListCheck.TabIndex = 23;
            this.AllLibraryAndListCheck.Text = "All libraries && lists";
            this.toolTip1.SetToolTip(this.AllLibraryAndListCheck, "All library & list page urls will be tested");
            this.AllLibraryAndListCheck.UseVisualStyleBackColor = false;
            // 
            // SubSiteCheck
            // 
            this.SubSiteCheck.AutoSize = true;
            this.SubSiteCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SubSiteCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.SubSiteCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubSiteCheck.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.SubSiteCheck.Location = new System.Drawing.Point(153, 54);
            this.SubSiteCheck.Name = "SubSiteCheck";
            this.SubSiteCheck.Size = new System.Drawing.Size(100, 23);
            this.SubSiteCheck.TabIndex = 22;
            this.SubSiteCheck.Text = "All sub sites";
            this.toolTip1.SetToolTip(this.SubSiteCheck, "All sub site home page urls will be tested");
            this.SubSiteCheck.UseVisualStyleBackColor = false;
            // 
            // UrlOnlyCheck
            // 
            this.UrlOnlyCheck.AutoSize = true;
            this.UrlOnlyCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UrlOnlyCheck.Checked = true;
            this.UrlOnlyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UrlOnlyCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.UrlOnlyCheck.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UrlOnlyCheck.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.UrlOnlyCheck.Location = new System.Drawing.Point(6, 54);
            this.UrlOnlyCheck.Name = "UrlOnlyCheck";
            this.UrlOnlyCheck.Size = new System.Drawing.Size(140, 23);
            this.UrlOnlyCheck.TabIndex = 21;
            this.UrlOnlyCheck.Text = "Test only given url";
            this.UrlOnlyCheck.UseVisualStyleBackColor = false;
            this.UrlOnlyCheck.CheckedChanged += new System.EventHandler(this.UrlOnlyCheck_CheckedChanged);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.BackColor = System.Drawing.Color.White;
            this.ExecuteButton.Caption = "Test";
            this.ExecuteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteButton.Description = null;
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExecuteButton.HasBorder = true;
            this.ExecuteButton.HasRightSideBorder = false;
            this.ExecuteButton.Image = null;
            this.ExecuteButton.Is2PaneDrawing = false;
            this.ExecuteButton.IsImageTransparent = false;
            this.ExecuteButton.IsMouseOn = false;
            this.ExecuteButton.IsRadio = false;
            this.ExecuteButton.Location = new System.Drawing.Point(417, 6);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.ShowDescriptionOnHover = true;
            this.ExecuteButton.Size = new System.Drawing.Size(101, 45);
            this.ExecuteButton.TabIndex = 19;
            this.ExecuteButton.Text = "Quick Test";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.ExecuteButton, "Get the Average Response Time for multiple requests");
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
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
            this.grid.Font = new System.Drawing.Font("Verdana", 9F);
            this.grid.Location = new System.Drawing.Point(0, 79);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.NoSelectedColor = false;
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 45;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(395, 305);
            this.grid.TabIndex = 32;
            this.toolTip1.SetToolTip(this.grid, "(double click for details)");
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Caption = null;
            this.stylingWorkarea1.Controls.Add(this.label6);
            this.stylingWorkarea1.Controls.Add(this.StatusPanel);
            this.stylingWorkarea1.Controls.Add(this.label5);
            this.stylingWorkarea1.Controls.Add(this.ExceptionCountLabel);
            this.stylingWorkarea1.Controls.Add(this.label4);
            this.stylingWorkarea1.Controls.Add(this.CountLabel);
            this.stylingWorkarea1.Controls.Add(this.label3);
            this.stylingWorkarea1.Controls.Add(this.TestTypeLabel);
            this.stylingWorkarea1.Controls.Add(this.label2);
            this.stylingWorkarea1.Controls.Add(this.stylingHeaderPanel1);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Right;
            this.stylingWorkarea1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea1.HasBorder = true;
            this.stylingWorkarea1.Image = null;
            this.stylingWorkarea1.IsImageTransparent = false;
            this.stylingWorkarea1.Location = new System.Drawing.Point(395, 79);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(254, 305);
            this.stylingWorkarea1.TabIndex = 31;
            this.stylingWorkarea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(7, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Recommended Avg. Response Time is 3 sec";
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.LightGray;
            this.StatusPanel.Caption = null;
            this.StatusPanel.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.StatusPanel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusPanel.HasBorder = true;
            this.StatusPanel.Image = null;
            this.StatusPanel.IsImageTransparent = false;
            this.StatusPanel.Location = new System.Drawing.Point(88, 112);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(163, 24);
            this.StatusPanel.Status = Squadron.Widgets.StatusPanel.StatusEnum.None;
            this.StatusPanel.TabIndex = 4;
            this.StatusPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status:";
            // 
            // ExceptionCountLabel
            // 
            this.ExceptionCountLabel.AutoSize = true;
            this.ExceptionCountLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExceptionCountLabel.Location = new System.Drawing.Point(85, 87);
            this.ExceptionCountLabel.Name = "ExceptionCountLabel";
            this.ExceptionCountLabel.Size = new System.Drawing.Size(0, 15);
            this.ExceptionCountLabel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exceptions:";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.Location = new System.Drawing.Point(85, 59);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(0, 15);
            this.CountLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Count:";
            // 
            // TestTypeLabel
            // 
            this.TestTypeLabel.AutoSize = true;
            this.TestTypeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestTypeLabel.Location = new System.Drawing.Point(85, 31);
            this.TestTypeLabel.Name = "TestTypeLabel";
            this.TestTypeLabel.Size = new System.Drawing.Size(0, 15);
            this.TestTypeLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Type:";
            // 
            // stylingHeaderPanel1
            // 
            this.stylingHeaderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.stylingHeaderPanel1.Caption = null;
            this.stylingHeaderPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingHeaderPanel1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingHeaderPanel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingHeaderPanel1.HasBorder = true;
            this.stylingHeaderPanel1.Image = null;
            this.stylingHeaderPanel1.IsImageTransparent = false;
            this.stylingHeaderPanel1.Location = new System.Drawing.Point(0, 0);
            this.stylingHeaderPanel1.Name = "stylingHeaderPanel1";
            this.stylingHeaderPanel1.Size = new System.Drawing.Size(254, 24);
            this.stylingHeaderPanel1.TabIndex = 0;
            this.stylingHeaderPanel1.Text = "Result Summary";
            this.stylingHeaderPanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // QuickTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.stylingWorkarea1);
            this.Controls.Add(this.panel1);
            this.Name = "QuickTestControl";
            this.Size = new System.Drawing.Size(649, 384);
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.stylingWorkarea1.ResumeLayout(false);
            this.stylingWorkarea1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TotalLabel;
        public System.Windows.Forms.TextBox UrlText;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private System.Windows.Forms.NumericUpDown CountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private Windows8LookNFeel.Windows8GridView grid;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TestTypeLabel;
        private System.Windows.Forms.Label ExceptionCountLabel;
        private System.Windows.Forms.Label CountLabel;
        private Squadron.Widgets.StatusPanel StatusPanel;
        private Windows8LookNFeel.Windows8CheckBox AllLibraryAndListCheck;
        private Windows8LookNFeel.Windows8CheckBox SubSiteCheck;
        private Windows8LookNFeel.Windows8CheckBox UrlOnlyCheck;
        private Windows8LookNFeel.Windows8CheckBox AllDocumentsAndItemsCheck;
        private Windows8LookNFeel.Windows8Button ThreadedTestButton;
        private System.Windows.Forms.Label label6;
    }
}
