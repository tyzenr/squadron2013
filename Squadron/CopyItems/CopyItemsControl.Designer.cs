namespace SquadronAddins.Default.CopyItems
{
    partial class CopyItemsControl
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.Refresh1 = new Windows8LookNFeel.Windows8Button();
            this.Url1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Refresh2 = new Windows8LookNFeel.Windows8Button();
            this.Url2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbr2 = new System.Windows.Forms.ProgressBar();
            this.pbr1 = new System.Windows.Forms.ProgressBar();
            this.CopyButton = new Windows8LookNFeel.Windows8Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.List1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copyControl1 = new SquadronAddins.Default.CopyItems.CopyControl();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Refresh1);
            this.panel6.Controls.Add(this.Url1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(773, 46);
            this.panel6.TabIndex = 6;
            // 
            // Refresh1
            // 
            this.Refresh1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.Refresh1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Refresh1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Refresh1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Refresh1.ForeColor = System.Drawing.Color.White;
            this.Refresh1.Image = null;
            this.Refresh1.Location = new System.Drawing.Point(700, 15);
            this.Refresh1.Name = "Refresh1";
            this.Refresh1.Size = new System.Drawing.Size(73, 31);
            this.Refresh1.TabIndex = 8;
            this.Refresh1.Text = "Refresh";
            this.Refresh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Refresh1.Click += new System.EventHandler(this.Refresh1_Click);
            // 
            // Url1
            // 
            this.Url1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Url1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Url1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Url1.Location = new System.Drawing.Point(4, 18);
            this.Url1.Name = "Url1";
            this.Url1.Size = new System.Drawing.Size(690, 25);
            this.Url1.TabIndex = 6;
            this.Url1.Text = "http://localhost";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Step 1: Source Server Connect";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(779, 433);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.copyControl1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(773, 127);
            this.panel4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(773, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Step 4: Finalize";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Refresh2);
            this.panel2.Controls.Add(this.Url2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 46);
            this.panel2.TabIndex = 10;
            // 
            // Refresh2
            // 
            this.Refresh2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.Refresh2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Refresh2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Refresh2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Refresh2.ForeColor = System.Drawing.Color.White;
            this.Refresh2.Image = null;
            this.Refresh2.Location = new System.Drawing.Point(700, 15);
            this.Refresh2.Name = "Refresh2";
            this.Refresh2.Size = new System.Drawing.Size(73, 31);
            this.Refresh2.TabIndex = 9;
            this.Refresh2.Text = "Refresh";
            this.Refresh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Refresh2.Click += new System.EventHandler(this.Refresh2_Click);
            // 
            // Url2
            // 
            this.Url2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Url2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Url2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Url2.Location = new System.Drawing.Point(4, 18);
            this.Url2.Name = "Url2";
            this.Url2.Size = new System.Drawing.Size(690, 25);
            this.Url2.TabIndex = 6;
            this.Url2.Text = "http://localhost";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(773, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Step 3: Destination Server Connect";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbr2);
            this.panel3.Controls.Add(this.pbr1);
            this.panel3.Controls.Add(this.CopyButton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 57);
            this.panel3.TabIndex = 9;
            // 
            // pbr2
            // 
            this.pbr2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbr2.Location = new System.Drawing.Point(4, 40);
            this.pbr2.Name = "pbr2";
            this.pbr2.Size = new System.Drawing.Size(578, 8);
            this.pbr2.TabIndex = 11;
            // 
            // pbr1
            // 
            this.pbr1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbr1.Location = new System.Drawing.Point(4, 24);
            this.pbr1.Name = "pbr1";
            this.pbr1.Size = new System.Drawing.Size(578, 13);
            this.pbr1.TabIndex = 10;
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.CopyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CopyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CopyButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CopyButton.ForeColor = System.Drawing.Color.White;
            this.CopyButton.Image = null;
            this.CopyButton.Location = new System.Drawing.Point(585, 15);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(188, 42);
            this.CopyButton.TabIndex = 9;
            this.CopyButton.Text = "Copy";
            this.CopyButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(773, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Step 5: Copy Items";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.List1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 127);
            this.panel1.TabIndex = 7;
            // 
            // List1
            // 
            this.List1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List1.FormattingEnabled = true;
            this.List1.Location = new System.Drawing.Point(0, 15);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(773, 112);
            this.List1.Sorted = true;
            this.List1.TabIndex = 4;
            this.List1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.List1_ItemCheck);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(773, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Step 2: Source List Select";
            // 
            // copyControl1
            // 
            this.copyControl1.AutoSize = true;
            this.copyControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyControl1.Location = new System.Drawing.Point(0, 15);
            this.copyControl1.Name = "copyControl1";
            this.copyControl1.Size = new System.Drawing.Size(773, 112);
            this.copyControl1.TabIndex = 3;
            // 
            // CopyItemsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "CopyItemsControl";
            this.Size = new System.Drawing.Size(779, 433);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private Windows8LookNFeel.Windows8Button Refresh1;
        public System.Windows.Forms.TextBox Url1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox List1;
        private System.Windows.Forms.Panel panel3;
        private Windows8LookNFeel.Windows8Button CopyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox Url2;
        private System.Windows.Forms.Label label3;
        private Windows8LookNFeel.Windows8Button Refresh2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private CopyControl copyControl1;
        private System.Windows.Forms.ProgressBar pbr2;
        private System.Windows.Forms.ProgressBar pbr1;


    }
}
