using System.ComponentModel;

namespace SquadronAddins.Infra
{
    partial class SystemControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemControl));
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stylingWorkarea3 = new Windows8LookNFeel.Windows8Panel();
            this.stylingHeaderPanel3 = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea2 = new Windows8LookNFeel.Windows8Panel();
            this.grids = new Windows8LookNFeel.Windows8GridView();
            this.stylingHeaderPanel2 = new Windows8LookNFeel.Windows8Panel();
            this.RefreshServicesButton = new System.Windows.Forms.PictureBox();
            this.stylingWorkarea4 = new Windows8LookNFeel.Windows8Panel();
            this.gridp = new Windows8LookNFeel.Windows8GridView();
            this.stylingHeaderPanel1 = new Windows8LookNFeel.Windows8Panel();
            this.RefreshProcessesButton = new System.Windows.Forms.PictureBox();
            this.pgrid = new System.Windows.Forms.PropertyGrid();
            this.FileText = new System.Windows.Forms.TextBox();
            this.FileLockButton = new System.Windows.Forms.PictureBox();
            this.stylingWorkarea1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.stylingWorkarea3.SuspendLayout();
            this.stylingWorkarea2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grids)).BeginInit();
            this.stylingHeaderPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshServicesButton)).BeginInit();
            this.stylingWorkarea4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridp)).BeginInit();
            this.stylingHeaderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshProcessesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileLockButton)).BeginInit();
            this.SuspendLayout();
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Controls.Add(this.tableLayoutPanel1);
            this.stylingWorkarea1.Controls.Add(this.pgrid);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea1.Location = new System.Drawing.Point(0, 0);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(732, 337);
            this.stylingWorkarea1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 337);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // stylingWorkarea3
            // 
            this.stylingWorkarea3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea3.Controls.Add(this.FileLockButton);
            this.stylingWorkarea3.Controls.Add(this.FileText);
            this.stylingWorkarea3.Controls.Add(this.stylingHeaderPanel3);
            this.stylingWorkarea3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea3.Location = new System.Drawing.Point(3, 267);
            this.stylingWorkarea3.Name = "stylingWorkarea3";
            this.stylingWorkarea3.Size = new System.Drawing.Size(465, 67);
            this.stylingWorkarea3.TabIndex = 2;
            // 
            // stylingHeaderPanel3
            // 
            this.stylingHeaderPanel3.BackColor = System.Drawing.Color.LightGray;
            this.stylingHeaderPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingHeaderPanel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingHeaderPanel3.Image = null;
            this.stylingHeaderPanel3.Location = new System.Drawing.Point(0, 0);
            this.stylingHeaderPanel3.Name = "stylingHeaderPanel3";
            this.stylingHeaderPanel3.Size = new System.Drawing.Size(465, 24);
            this.stylingHeaderPanel3.TabIndex = 1;
            this.stylingHeaderPanel3.Text = "File Lock";
            this.stylingHeaderPanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stylingWorkarea2
            // 
            this.stylingWorkarea2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea2.Controls.Add(this.grids);
            this.stylingWorkarea2.Controls.Add(this.stylingHeaderPanel2);
            this.stylingWorkarea2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea2.Location = new System.Drawing.Point(3, 135);
            this.stylingWorkarea2.Name = "stylingWorkarea2";
            this.stylingWorkarea2.Size = new System.Drawing.Size(465, 126);
            this.stylingWorkarea2.TabIndex = 1;
            // 
            // grids
            // 
            this.grids.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grids.Font = new System.Drawing.Font("Verdana", 9F);
            this.grids.Location = new System.Drawing.Point(0, 24);
            this.grids.MultiSelect = false;
            this.grids.Name = "grids";
            this.grids.ReadOnly = true;
            this.grids.RowTemplate.Height = 45;
            this.grids.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grids.Size = new System.Drawing.Size(465, 102);
            this.grids.TabIndex = 20;
            this.grids.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grids_CellClick);
            // 
            // stylingHeaderPanel2
            // 
            this.stylingHeaderPanel2.BackColor = System.Drawing.Color.LightGray;
            this.stylingHeaderPanel2.Controls.Add(this.RefreshServicesButton);
            this.stylingHeaderPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingHeaderPanel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingHeaderPanel2.Image = null;
            this.stylingHeaderPanel2.Location = new System.Drawing.Point(0, 0);
            this.stylingHeaderPanel2.Name = "stylingHeaderPanel2";
            this.stylingHeaderPanel2.Size = new System.Drawing.Size(465, 24);
            this.stylingHeaderPanel2.TabIndex = 1;
            this.stylingHeaderPanel2.Text = "Services";
            this.stylingHeaderPanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RefreshServicesButton
            // 
            this.RefreshServicesButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshServicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshServicesButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshServicesButton.Image")));
            this.RefreshServicesButton.Location = new System.Drawing.Point(71, 2);
            this.RefreshServicesButton.Name = "RefreshServicesButton";
            this.RefreshServicesButton.Size = new System.Drawing.Size(21, 21);
            this.RefreshServicesButton.TabIndex = 24;
            this.RefreshServicesButton.TabStop = false;
            this.RefreshServicesButton.Click += new System.EventHandler(this.RefreshServicesButton_Click);
            // 
            // stylingWorkarea4
            // 
            this.stylingWorkarea4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea4.Controls.Add(this.gridp);
            this.stylingWorkarea4.Controls.Add(this.stylingHeaderPanel1);
            this.stylingWorkarea4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea4.Location = new System.Drawing.Point(3, 3);
            this.stylingWorkarea4.Name = "stylingWorkarea4";
            this.stylingWorkarea4.Size = new System.Drawing.Size(465, 126);
            this.stylingWorkarea4.TabIndex = 0;
            // 
            // gridp
            // 
            this.gridp.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gridp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridp.Font = new System.Drawing.Font("Verdana", 9F);
            this.gridp.Location = new System.Drawing.Point(0, 24);
            this.gridp.MultiSelect = false;
            this.gridp.Name = "gridp";
            this.gridp.ReadOnly = true;
            this.gridp.RowTemplate.Height = 45;
            this.gridp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridp.Size = new System.Drawing.Size(465, 102);
            this.gridp.TabIndex = 20;
            this.gridp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridp_CellClick);
            // 
            // stylingHeaderPanel1
            // 
            this.stylingHeaderPanel1.BackColor = System.Drawing.Color.LightGray;
            this.stylingHeaderPanel1.Controls.Add(this.RefreshProcessesButton);
            this.stylingHeaderPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingHeaderPanel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingHeaderPanel1.Image = null;
            this.stylingHeaderPanel1.Location = new System.Drawing.Point(0, 0);
            this.stylingHeaderPanel1.Name = "stylingHeaderPanel1";
            this.stylingHeaderPanel1.Size = new System.Drawing.Size(465, 24);
            this.stylingHeaderPanel1.TabIndex = 1;
            this.stylingHeaderPanel1.Text = "Processes";
            this.stylingHeaderPanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RefreshProcessesButton
            // 
            this.RefreshProcessesButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshProcessesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshProcessesButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshProcessesButton.Image")));
            this.RefreshProcessesButton.Location = new System.Drawing.Point(71, 2);
            this.RefreshProcessesButton.Name = "RefreshProcessesButton";
            this.RefreshProcessesButton.Size = new System.Drawing.Size(21, 21);
            this.RefreshProcessesButton.TabIndex = 23;
            this.RefreshProcessesButton.TabStop = false;
            this.RefreshProcessesButton.Click += new System.EventHandler(this.RefreshProcessesButton_Click);
            // 
            // pgrid
            // 
            this.pgrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.pgrid.Location = new System.Drawing.Point(471, 0);
            this.pgrid.Name = "pgrid";
            this.pgrid.Size = new System.Drawing.Size(261, 337);
            this.pgrid.TabIndex = 19;
            // 
            // FileText
            // 
            this.FileText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FileText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileText.Location = new System.Drawing.Point(8, 30);
            this.FileText.Name = "FileText";
            this.FileText.Size = new System.Drawing.Size(427, 25);
            this.FileText.TabIndex = 17;
            this.FileText.Text = "Enter file path to see which Process is locking it..";
            // 
            // FileLockButton
            // 
            this.FileLockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileLockButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileLockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileLockButton.Image = ((System.Drawing.Image)(resources.GetObject("FileLockButton.Image")));
            this.FileLockButton.Location = new System.Drawing.Point(438, 30);
            this.FileLockButton.Name = "FileLockButton";
            this.FileLockButton.Size = new System.Drawing.Size(24, 25);
            this.FileLockButton.TabIndex = 25;
            this.FileLockButton.TabStop = false;
            this.FileLockButton.Click += new System.EventHandler(this.FileLockButton_Click);
            // 
            // SystemControl
            // 
            this.Controls.Add(this.stylingWorkarea1);
            this.Name = "SystemControl";
            this.Size = new System.Drawing.Size(732, 337);
            this.stylingWorkarea1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.stylingWorkarea3.ResumeLayout(false);
            this.stylingWorkarea3.PerformLayout();
            this.stylingWorkarea2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grids)).EndInit();
            this.stylingHeaderPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshServicesButton)).EndInit();
            this.stylingWorkarea4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridp)).EndInit();
            this.stylingHeaderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshProcessesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileLockButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea3;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel3;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea2;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel2;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea4;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel1;
        private System.Windows.Forms.PropertyGrid pgrid;
        private Windows8LookNFeel.Windows8GridView grids;
        private Windows8LookNFeel.Windows8GridView gridp;
        private System.Windows.Forms.PictureBox RefreshProcessesButton;
        private System.Windows.Forms.PictureBox RefreshServicesButton;
        private System.Windows.Forms.PictureBox FileLockButton;
        public System.Windows.Forms.TextBox FileText;

    }
}
