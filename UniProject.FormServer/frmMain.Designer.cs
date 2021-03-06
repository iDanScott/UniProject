﻿namespace UniProject.FormServer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLockAll = new System.Windows.Forms.ToolStripDropDownButton();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlScreenViewer1 = new UniProject.FormServer.ctrlScreenViewer();
            this.ctrlScreenViewer2 = new UniProject.FormServer.ctrlScreenViewer();
            this.ctrlScreenViewer3 = new UniProject.FormServer.ctrlScreenViewer();
            this.layoutPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoScroll = true;
            this.layoutPanel.BackColor = System.Drawing.Color.White;
            this.layoutPanel.Controls.Add(this.ctrlScreenViewer1);
            this.layoutPanel.Controls.Add(this.ctrlScreenViewer2);
            this.layoutPanel.Controls.Add(this.ctrlScreenViewer3);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(913, 479);
            this.layoutPanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLockAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1017, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLockAll
            // 
            this.btnLockAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLockAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.openWebToolStripMenuItem});
            this.btnLockAll.Image = ((System.Drawing.Image)(resources.GetObject("btnLockAll.Image")));
            this.btnLockAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLockAll.Name = "btnLockAll";
            this.btnLockAll.Size = new System.Drawing.Size(73, 22);
            this.btnLockAll.Text = "All Clients";
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.winAPIToolStripMenuItem,
            this.softToolStripMenuItem});
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            // 
            // winAPIToolStripMenuItem
            // 
            this.winAPIToolStripMenuItem.Name = "winAPIToolStripMenuItem";
            this.winAPIToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.winAPIToolStripMenuItem.Text = "WinAPI";
            this.winAPIToolStripMenuItem.Click += new System.EventHandler(this.btnLockAllWinAPI_Click);
            // 
            // softToolStripMenuItem
            // 
            this.softToolStripMenuItem.Name = "softToolStripMenuItem";
            this.softToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.softToolStripMenuItem.Text = "Soft";
            this.softToolStripMenuItem.Click += new System.EventHandler(this.btnLockAllSoftAPI_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.layoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtLog);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 479);
            this.splitContainer1.SplitterDistance = 913;
            this.splitContainer1.TabIndex = 2;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(100, 479);
            this.txtLog.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // openWebToolStripMenuItem
            // 
            this.openWebToolStripMenuItem.Name = "openWebToolStripMenuItem";
            this.openWebToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openWebToolStripMenuItem.Text = "Start Process";
            this.openWebToolStripMenuItem.Click += new System.EventHandler(this.openWebToolStripMenuItem_Click);
            // 
            // ctrlScreenViewer1
            // 
            this.ctrlScreenViewer1.Location = new System.Drawing.Point(3, 3);
            this.ctrlScreenViewer1.Name = "ctrlScreenViewer1";
            this.ctrlScreenViewer1.Size = new System.Drawing.Size(293, 190);
            this.ctrlScreenViewer1.TabIndex = 0;
            // 
            // ctrlScreenViewer2
            // 
            this.ctrlScreenViewer2.Location = new System.Drawing.Point(302, 3);
            this.ctrlScreenViewer2.Name = "ctrlScreenViewer2";
            this.ctrlScreenViewer2.Size = new System.Drawing.Size(293, 190);
            this.ctrlScreenViewer2.TabIndex = 1;
            // 
            // ctrlScreenViewer3
            // 
            this.ctrlScreenViewer3.Location = new System.Drawing.Point(601, 3);
            this.ctrlScreenViewer3.Name = "ctrlScreenViewer3";
            this.ctrlScreenViewer3.Size = new System.Drawing.Size(293, 190);
            this.ctrlScreenViewer3.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 532);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "UniProject.FormServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.layoutPanel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtLog;
        private ctrlScreenViewer ctrlScreenViewer1;
        private ctrlScreenViewer ctrlScreenViewer2;
        private ctrlScreenViewer ctrlScreenViewer3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnLockAll;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winAPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWebToolStripMenuItem;
    }
}

