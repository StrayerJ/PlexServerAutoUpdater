﻿/*
 * Created by SharpDevelop.
 * User: Paul
 * Date: 2/22/2016
 * Time: 7:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TE.Plex
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.GroupBox grpUpdateStatus;
		private System.Windows.Forms.TextBox txtUpdateStatus;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblLatestVersion;
		private System.Windows.Forms.Label lblInstalledVersion;
		private System.Windows.Forms.Label lblLatestVersionLabel;
		private System.Windows.Forms.Label lblInstalledVersionLabel;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpUpdateStatus = new System.Windows.Forms.GroupBox();
            this.txtUpdateStatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlayCount = new System.Windows.Forms.Label();
            this.lblPlayCountLabel = new System.Windows.Forms.Label();
            this.lblLatestVersion = new System.Windows.Forms.Label();
            this.lblInstalledVersion = new System.Windows.Forms.Label();
            this.lblLatestVersionLabel = new System.Windows.Forms.Label();
            this.lblInstalledVersionLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkWait = new System.Windows.Forms.CheckBox();
            this.lblCheckEveryLabel = new System.Windows.Forms.Label();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblCheckSecondsLabel = new System.Windows.Forms.Label();
            this.grpUpdateStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(476, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(394, 429);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
            // 
            // grpUpdateStatus
            // 
            this.grpUpdateStatus.Controls.Add(this.txtUpdateStatus);
            this.grpUpdateStatus.Location = new System.Drawing.Point(12, 117);
            this.grpUpdateStatus.Name = "grpUpdateStatus";
            this.grpUpdateStatus.Size = new System.Drawing.Size(538, 289);
            this.grpUpdateStatus.TabIndex = 3;
            this.grpUpdateStatus.TabStop = false;
            this.grpUpdateStatus.Text = "Update Status:";
            // 
            // txtUpdateStatus
            // 
            this.txtUpdateStatus.Location = new System.Drawing.Point(7, 20);
            this.txtUpdateStatus.Multiline = true;
            this.txtUpdateStatus.Name = "txtUpdateStatus";
            this.txtUpdateStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUpdateStatus.Size = new System.Drawing.Size(525, 263);
            this.txtUpdateStatus.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlayCount);
            this.groupBox1.Controls.Add(this.lblPlayCountLabel);
            this.groupBox1.Controls.Add(this.lblLatestVersion);
            this.groupBox1.Controls.Add(this.lblInstalledVersion);
            this.groupBox1.Controls.Add(this.lblLatestVersionLabel);
            this.groupBox1.Controls.Add(this.lblInstalledVersionLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plex Media Server Information";
            // 
            // lblPlayCount
            // 
            this.lblPlayCount.Location = new System.Drawing.Point(178, 66);
            this.lblPlayCount.Name = "lblPlayCount";
            this.lblPlayCount.Size = new System.Drawing.Size(100, 17);
            this.lblPlayCount.TabIndex = 7;
            this.lblPlayCount.Text = "[]";
            // 
            // lblPlayCountLabel
            // 
            this.lblPlayCountLabel.AutoSize = true;
            this.lblPlayCountLabel.Location = new System.Drawing.Point(7, 66);
            this.lblPlayCountLabel.Name = "lblPlayCountLabel";
            this.lblPlayCountLabel.Size = new System.Drawing.Size(165, 13);
            this.lblPlayCountLabel.TabIndex = 6;
            this.lblPlayCountLabel.Text = "Number of items currently playing:";
            // 
            // lblLatestVersion
            // 
            this.lblLatestVersion.Location = new System.Drawing.Point(178, 43);
            this.lblLatestVersion.Name = "lblLatestVersion";
            this.lblLatestVersion.Size = new System.Drawing.Size(100, 13);
            this.lblLatestVersion.TabIndex = 3;
            this.lblLatestVersion.Text = "[]";
            // 
            // lblInstalledVersion
            // 
            this.lblInstalledVersion.Location = new System.Drawing.Point(178, 20);
            this.lblInstalledVersion.Name = "lblInstalledVersion";
            this.lblInstalledVersion.Size = new System.Drawing.Size(100, 13);
            this.lblInstalledVersion.TabIndex = 2;
            this.lblInstalledVersion.Text = "[]";
            // 
            // lblLatestVersionLabel
            // 
            this.lblLatestVersionLabel.Location = new System.Drawing.Point(6, 43);
            this.lblLatestVersionLabel.Name = "lblLatestVersionLabel";
            this.lblLatestVersionLabel.Size = new System.Drawing.Size(100, 13);
            this.lblLatestVersionLabel.TabIndex = 1;
            this.lblLatestVersionLabel.Text = "Latest Version:";
            // 
            // lblInstalledVersionLabel
            // 
            this.lblInstalledVersionLabel.Location = new System.Drawing.Point(7, 20);
            this.lblInstalledVersionLabel.Name = "lblInstalledVersionLabel";
            this.lblInstalledVersionLabel.Size = new System.Drawing.Size(99, 13);
            this.lblInstalledVersionLabel.TabIndex = 0;
            this.lblInstalledVersionLabel.Text = "Installed Version:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(475, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkWait
            // 
            this.chkWait.AutoSize = true;
            this.chkWait.Checked = true;
            this.chkWait.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWait.Location = new System.Drawing.Point(19, 412);
            this.chkWait.Name = "chkWait";
            this.chkWait.Size = new System.Drawing.Size(161, 17);
            this.chkWait.TabIndex = 6;
            this.chkWait.Text = "Only update when not in use";
            this.chkWait.UseVisualStyleBackColor = true;
            this.chkWait.CheckedChanged += new System.EventHandler(this.chkWait_CheckedChanged);
            // 
            // lblCheckEveryLabel
            // 
            this.lblCheckEveryLabel.AutoSize = true;
            this.lblCheckEveryLabel.Location = new System.Drawing.Point(16, 439);
            this.lblCheckEveryLabel.Name = "lblCheckEveryLabel";
            this.lblCheckEveryLabel.Size = new System.Drawing.Size(67, 13);
            this.lblCheckEveryLabel.TabIndex = 7;
            this.lblCheckEveryLabel.Text = "Check every";
            // 
            // numSeconds
            // 
            this.numSeconds.Location = new System.Drawing.Point(89, 437);
            this.numSeconds.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numSeconds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(53, 20);
            this.numSeconds.TabIndex = 8;
            this.numSeconds.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblCheckSecondsLabel
            // 
            this.lblCheckSecondsLabel.AutoSize = true;
            this.lblCheckSecondsLabel.Location = new System.Drawing.Point(148, 439);
            this.lblCheckSecondsLabel.Name = "lblCheckSecondsLabel";
            this.lblCheckSecondsLabel.Size = new System.Drawing.Size(47, 13);
            this.lblCheckSecondsLabel.TabIndex = 9;
            this.lblCheckSecondsLabel.Text = "seconds";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 472);
            this.Controls.Add(this.lblCheckSecondsLabel);
            this.Controls.Add(this.numSeconds);
            this.Controls.Add(this.lblCheckEveryLabel);
            this.Controls.Add(this.chkWait);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpUpdateStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plex Server Updater";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.grpUpdateStatus.ResumeLayout(false);
            this.grpUpdateStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlayCount;
        private System.Windows.Forms.Label lblPlayCountLabel;
        private System.Windows.Forms.CheckBox chkWait;
        private System.Windows.Forms.Label lblCheckEveryLabel;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.Label lblCheckSecondsLabel;
    }
}
