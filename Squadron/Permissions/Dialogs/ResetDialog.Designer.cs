namespace SquadronAddIns.Default.Permissions.Dialogs
{
    partial class ResetDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stylingWorkarea4 = new Windows8LookNFeel.Windows8Panel();
            this.ResetButton = new Windows8LookNFeel.Windows8Button();
            this.stylingWorkarea3 = new Windows8LookNFeel.Windows8Panel();
            this.ItemsList = new System.Windows.Forms.CheckedListBox();
            this.stylingHeaderPanel1 = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea2 = new Windows8LookNFeel.Windows8Panel();
            this.FindButton = new Windows8LookNFeel.Windows8Button();
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.browser = new SquadronAddIns.Default.Components.SharePointExplorer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.stylingWorkarea4.SuspendLayout();
            this.stylingWorkarea3.SuspendLayout();
            this.stylingWorkarea2.SuspendLayout();
            this.stylingWorkarea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.tableLayoutPanel1);
            this.WorkareaPanel.Size = new System.Drawing.Size(872, 436);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HeaderPanel.Size = new System.Drawing.Size(872, 45);
            this.HeaderPanel.Text = "Reset Permissions";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FooterPanel.Location = new System.Drawing.Point(0, 481);
            this.FooterPanel.Size = new System.Drawing.Size(872, 27);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(841, 15);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.02752F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.288991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0367F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.87615F));
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // stylingWorkarea4
            // 
            this.stylingWorkarea4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea4.Controls.Add(this.ResetButton);
            this.stylingWorkarea4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea4.Location = new System.Drawing.Point(753, 3);
            this.stylingWorkarea4.Name = "stylingWorkarea4";
            this.stylingWorkarea4.Size = new System.Drawing.Size(116, 430);
            this.stylingWorkarea4.TabIndex = 3;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ResetButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Image = null;
            this.ResetButton.Location = new System.Drawing.Point(0, 0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(116, 430);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Tag = ";";
            this.ResetButton.Text = "Reset";
            this.ResetButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.ResetButton, "Reset permissions to Inherit");
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // stylingWorkarea3
            // 
            this.stylingWorkarea3.BackColor = System.Drawing.Color.Snow;
            this.stylingWorkarea3.Controls.Add(this.ItemsList);
            this.stylingWorkarea3.Controls.Add(this.stylingHeaderPanel1);
            this.stylingWorkarea3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea3.Location = new System.Drawing.Point(370, 3);
            this.stylingWorkarea3.Name = "stylingWorkarea3";
            this.stylingWorkarea3.Size = new System.Drawing.Size(377, 430);
            this.stylingWorkarea3.TabIndex = 2;
            // 
            // ItemsList
            // 
            this.ItemsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsList.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.HorizontalScrollbar = true;
            this.ItemsList.Location = new System.Drawing.Point(0, 24);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(377, 406);
            this.ItemsList.TabIndex = 28;
            this.toolTip1.SetToolTip(this.ItemsList, "Double click to examine the Securable Object (Site, List/Library, Item) or User d" +
        "etails");
            // 
            // stylingHeaderPanel1
            // 
            this.stylingHeaderPanel1.BackColor = System.Drawing.Color.Silver;
            this.stylingHeaderPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingHeaderPanel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylingHeaderPanel1.Image = null;
            this.stylingHeaderPanel1.Location = new System.Drawing.Point(0, 0);
            this.stylingHeaderPanel1.Name = "stylingHeaderPanel1";
            this.stylingHeaderPanel1.Size = new System.Drawing.Size(377, 24);
            this.stylingHeaderPanel1.TabIndex = 27;
            this.stylingHeaderPanel1.Tag = ";";
            this.stylingHeaderPanel1.Text = "Unique Permissions";
            this.stylingHeaderPanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stylingWorkarea2
            // 
            this.stylingWorkarea2.BackColor = System.Drawing.Color.DarkRed;
            this.stylingWorkarea2.Controls.Add(this.FindButton);
            this.stylingWorkarea2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea2.Location = new System.Drawing.Point(290, 3);
            this.stylingWorkarea2.Name = "stylingWorkarea2";
            this.stylingWorkarea2.Size = new System.Drawing.Size(74, 430);
            this.stylingWorkarea2.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.FindButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FindButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.Image = null;
            this.FindButton.Location = new System.Drawing.Point(0, 0);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(74, 430);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.FindButton, "Find unique permission entries");
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.RoyalBlue;
            this.stylingWorkarea1.Controls.Add(this.browser);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea1.Location = new System.Drawing.Point(3, 3);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(281, 430);
            this.stylingWorkarea1.TabIndex = 0;
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 0);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(281, 430);
            this.browser.TabIndex = 0;
            this.browser.Url = null;
            // 
            // ResetDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 508);
            this.HeaderText = "Reset Permissions";
            this.Name = "ResetDialog";
            this.ShowFooter = true;
            this.Text = "Reset Permissions";
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.stylingWorkarea4.ResumeLayout(false);
            this.stylingWorkarea3.ResumeLayout(false);
            this.stylingWorkarea2.ResumeLayout(false);
            this.stylingWorkarea1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea4;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea3;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea2;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private Default.Components.SharePointExplorer browser;
        private Windows8LookNFeel.Windows8Button FindButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox ItemsList;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel1;
        private Windows8LookNFeel.Windows8Button ResetButton;
    }
}
