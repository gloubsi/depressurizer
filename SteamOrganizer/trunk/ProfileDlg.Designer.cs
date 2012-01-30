﻿namespace Depressurizer {
    partial class ProfileDlg {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileDlg));
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.cmbAccountID = new System.Windows.Forms.ComboBox();
            this.lblAccIDLabel = new System.Windows.Forms.Label();
            this.txtCommunityName = new System.Windows.Forms.TextBox();
            this.lblCommNameLabel = new System.Windows.Forms.Label();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.lblCommNameDesc = new System.Windows.Forms.Label();
            this.lblAccIDDesc = new System.Windows.Forms.Label();
            this.grpProfInfo = new System.Windows.Forms.GroupBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.chkActImport = new System.Windows.Forms.CheckBox();
            this.chkActDownload = new System.Windows.Forms.CheckBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.grpLoadOpt = new System.Windows.Forms.GroupBox();
            this.chkImportOnLoad = new System.Windows.Forms.CheckBox();
            this.chkDownloadOnLoad = new System.Windows.Forms.CheckBox();
            this.grpSaveOpt = new System.Windows.Forms.GroupBox();
            this.chkExportDiscard = new System.Windows.Forms.CheckBox();
            this.chkExportOnSave = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabOpts = new System.Windows.Forms.TabPage();
            this.chkImportDiscard = new System.Windows.Forms.CheckBox();
            this.grpUserInfo.SuspendLayout();
            this.grpProfInfo.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpLoadOpt.SuspendLayout();
            this.grpSaveOpt.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabOpts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(91, 13);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(435, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowse.Location = new System.Drawing.Point(532, 11);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(76, 23);
            this.cmdBrowse.TabIndex = 1;
            this.cmdBrowse.Text = "Browse...";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 16);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(79, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Profile file path:";
            // 
            // cmbAccountID
            // 
            this.cmbAccountID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccountID.FormattingEnabled = true;
            this.cmbAccountID.Location = new System.Drawing.Point(162, 13);
            this.cmbAccountID.Name = "cmbAccountID";
            this.cmbAccountID.Size = new System.Drawing.Size(446, 21);
            this.cmbAccountID.TabIndex = 3;
            // 
            // lblAccIDLabel
            // 
            this.lblAccIDLabel.AutoSize = true;
            this.lblAccIDLabel.Location = new System.Drawing.Point(59, 16);
            this.lblAccIDLabel.Name = "lblAccIDLabel";
            this.lblAccIDLabel.Size = new System.Drawing.Size(97, 13);
            this.lblAccIDLabel.TabIndex = 4;
            this.lblAccIDLabel.Text = "Steam Account ID:";
            // 
            // txtCommunityName
            // 
            this.txtCommunityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommunityName.Location = new System.Drawing.Point(162, 84);
            this.txtCommunityName.Name = "txtCommunityName";
            this.txtCommunityName.Size = new System.Drawing.Size(446, 20);
            this.txtCommunityName.TabIndex = 5;
            // 
            // lblCommNameLabel
            // 
            this.lblCommNameLabel.AutoSize = true;
            this.lblCommNameLabel.Location = new System.Drawing.Point(6, 87);
            this.lblCommNameLabel.Name = "lblCommNameLabel";
            this.lblCommNameLabel.Size = new System.Drawing.Size(150, 13);
            this.lblCommNameLabel.TabIndex = 6;
            this.lblCommNameLabel.Text = "Steam Community URL Name:";
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUserInfo.Controls.Add(this.lblCommNameDesc);
            this.grpUserInfo.Controls.Add(this.lblAccIDDesc);
            this.grpUserInfo.Controls.Add(this.lblAccIDLabel);
            this.grpUserInfo.Controls.Add(this.lblCommNameLabel);
            this.grpUserInfo.Controls.Add(this.txtCommunityName);
            this.grpUserInfo.Controls.Add(this.cmbAccountID);
            this.grpUserInfo.Location = new System.Drawing.Point(6, 52);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(614, 181);
            this.grpUserInfo.TabIndex = 7;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "User Info";
            // 
            // lblCommNameDesc
            // 
            this.lblCommNameDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommNameDesc.Location = new System.Drawing.Point(159, 107);
            this.lblCommNameDesc.Name = "lblCommNameDesc";
            this.lblCommNameDesc.Size = new System.Drawing.Size(449, 72);
            this.lblCommNameDesc.TabIndex = 8;
            this.lblCommNameDesc.Text = resources.GetString("lblCommNameDesc.Text");
            // 
            // lblAccIDDesc
            // 
            this.lblAccIDDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccIDDesc.Location = new System.Drawing.Point(162, 37);
            this.lblAccIDDesc.Name = "lblAccIDDesc";
            this.lblAccIDDesc.Size = new System.Drawing.Size(446, 41);
            this.lblAccIDDesc.TabIndex = 7;
            this.lblAccIDDesc.Text = "Your account ID should be a number. It determines where Steam stores your setting" +
    "s.\r\nThe list will contain all the IDs with saved info on this computer.";
            // 
            // grpProfInfo
            // 
            this.grpProfInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProfInfo.Controls.Add(this.txtFilePath);
            this.grpProfInfo.Controls.Add(this.cmdBrowse);
            this.grpProfInfo.Controls.Add(this.lblPath);
            this.grpProfInfo.Location = new System.Drawing.Point(6, 6);
            this.grpProfInfo.Name = "grpProfInfo";
            this.grpProfInfo.Size = new System.Drawing.Size(614, 40);
            this.grpProfInfo.TabIndex = 8;
            this.grpProfInfo.TabStop = false;
            this.grpProfInfo.Text = "Profile Info";
            // 
            // grpActions
            // 
            this.grpActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActions.Controls.Add(this.chkActImport);
            this.grpActions.Controls.Add(this.chkActDownload);
            this.grpActions.Location = new System.Drawing.Point(6, 239);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(614, 68);
            this.grpActions.TabIndex = 9;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Additional Actions";
            // 
            // chkActImport
            // 
            this.chkActImport.AutoSize = true;
            this.chkActImport.Location = new System.Drawing.Point(9, 44);
            this.chkActImport.Name = "chkActImport";
            this.chkActImport.Size = new System.Drawing.Size(209, 17);
            this.chkActImport.TabIndex = 1;
            this.chkActImport.Text = "Import categories from Steam right now";
            this.chkActImport.UseVisualStyleBackColor = true;
            // 
            // chkActDownload
            // 
            this.chkActDownload.AutoSize = true;
            this.chkActDownload.Location = new System.Drawing.Point(9, 20);
            this.chkActDownload.Name = "chkActDownload";
            this.chkActDownload.Size = new System.Drawing.Size(259, 17);
            this.chkActDownload.TabIndex = 0;
            this.chkActDownload.Text = "Download game list from community site right now";
            this.chkActDownload.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOk.Location = new System.Drawing.Point(571, 357);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 10;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(490, 357);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // grpLoadOpt
            // 
            this.grpLoadOpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLoadOpt.Controls.Add(this.chkImportDiscard);
            this.grpLoadOpt.Controls.Add(this.chkImportOnLoad);
            this.grpLoadOpt.Controls.Add(this.chkDownloadOnLoad);
            this.grpLoadOpt.Location = new System.Drawing.Point(6, 6);
            this.grpLoadOpt.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.grpLoadOpt.Name = "grpLoadOpt";
            this.grpLoadOpt.Size = new System.Drawing.Size(614, 87);
            this.grpLoadOpt.TabIndex = 0;
            this.grpLoadOpt.TabStop = false;
            this.grpLoadOpt.Text = "Profile Loading Options";
            // 
            // chkImportOnLoad
            // 
            this.chkImportOnLoad.AutoSize = true;
            this.chkImportOnLoad.Location = new System.Drawing.Point(6, 42);
            this.chkImportOnLoad.Name = "chkImportOnLoad";
            this.chkImportOnLoad.Size = new System.Drawing.Size(265, 17);
            this.chkImportOnLoad.TabIndex = 1;
            this.chkImportOnLoad.Text = "Automatically import categories from Steam on load";
            this.chkImportOnLoad.UseVisualStyleBackColor = true;
            // 
            // chkDownloadOnLoad
            // 
            this.chkDownloadOnLoad.AutoSize = true;
            this.chkDownloadOnLoad.Location = new System.Drawing.Point(6, 19);
            this.chkDownloadOnLoad.Name = "chkDownloadOnLoad";
            this.chkDownloadOnLoad.Size = new System.Drawing.Size(329, 17);
            this.chkDownloadOnLoad.TabIndex = 0;
            this.chkDownloadOnLoad.Text = "Automatically download game list from Steam Community on load";
            this.chkDownloadOnLoad.UseVisualStyleBackColor = true;
            // 
            // grpSaveOpt
            // 
            this.grpSaveOpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSaveOpt.Controls.Add(this.chkExportDiscard);
            this.grpSaveOpt.Controls.Add(this.chkExportOnSave);
            this.grpSaveOpt.Location = new System.Drawing.Point(6, 99);
            this.grpSaveOpt.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.grpSaveOpt.Name = "grpSaveOpt";
            this.grpSaveOpt.Size = new System.Drawing.Size(614, 65);
            this.grpSaveOpt.TabIndex = 1;
            this.grpSaveOpt.TabStop = false;
            this.grpSaveOpt.Text = "Profile Saving Options";
            // 
            // chkExportDiscard
            // 
            this.chkExportDiscard.AutoSize = true;
            this.chkExportDiscard.Location = new System.Drawing.Point(6, 42);
            this.chkExportDiscard.Name = "chkExportDiscard";
            this.chkExportDiscard.Size = new System.Drawing.Size(370, 17);
            this.chkExportDiscard.TabIndex = 1;
            this.chkExportDiscard.Text = "Remove entries for deleted or unknown games in Steam configuration file";
            this.chkExportDiscard.UseVisualStyleBackColor = true;
            // 
            // chkExportOnSave
            // 
            this.chkExportOnSave.AutoSize = true;
            this.chkExportOnSave.Location = new System.Drawing.Point(6, 19);
            this.chkExportOnSave.Name = "chkExportOnSave";
            this.chkExportOnSave.Size = new System.Drawing.Size(305, 17);
            this.chkExportOnSave.TabIndex = 0;
            this.chkExportOnSave.Text = "Automatically save categories to Steam when saving profile";
            this.chkExportOnSave.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabOpts);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(634, 339);
            this.tabControl.TabIndex = 13;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.grpProfInfo);
            this.tabMain.Controls.Add(this.grpUserInfo);
            this.tabMain.Controls.Add(this.grpActions);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(626, 313);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabOpts
            // 
            this.tabOpts.Controls.Add(this.grpSaveOpt);
            this.tabOpts.Controls.Add(this.grpLoadOpt);
            this.tabOpts.Location = new System.Drawing.Point(4, 22);
            this.tabOpts.Name = "tabOpts";
            this.tabOpts.Padding = new System.Windows.Forms.Padding(3);
            this.tabOpts.Size = new System.Drawing.Size(626, 313);
            this.tabOpts.TabIndex = 1;
            this.tabOpts.Text = "Options";
            this.tabOpts.UseVisualStyleBackColor = true;
            // 
            // chkImportDiscard
            // 
            this.chkImportDiscard.AutoSize = true;
            this.chkImportDiscard.Location = new System.Drawing.Point(6, 65);
            this.chkImportDiscard.Name = "chkImportDiscard";
            this.chkImportDiscard.Size = new System.Drawing.Size(238, 17);
            this.chkImportDiscard.TabIndex = 2;
            this.chkImportDiscard.Text = "Discard categories not found in Steam config";
            this.chkImportDiscard.UseVisualStyleBackColor = true;
            // 
            // ProfileDlg
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(658, 390);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProfileDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Profile";
            this.Load += new System.EventHandler(this.ProfileDlg_Load);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.grpProfInfo.ResumeLayout(false);
            this.grpProfInfo.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.grpLoadOpt.ResumeLayout(false);
            this.grpLoadOpt.PerformLayout();
            this.grpSaveOpt.ResumeLayout(false);
            this.grpSaveOpt.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabOpts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ComboBox cmbAccountID;
        private System.Windows.Forms.Label lblAccIDLabel;
        private System.Windows.Forms.TextBox txtCommunityName;
        private System.Windows.Forms.Label lblCommNameLabel;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.Label lblCommNameDesc;
        private System.Windows.Forms.Label lblAccIDDesc;
        private System.Windows.Forms.GroupBox grpProfInfo;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.CheckBox chkActImport;
        private System.Windows.Forms.CheckBox chkActDownload;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.GroupBox grpLoadOpt;
        private System.Windows.Forms.CheckBox chkImportOnLoad;
        private System.Windows.Forms.CheckBox chkDownloadOnLoad;
        private System.Windows.Forms.GroupBox grpSaveOpt;
        private System.Windows.Forms.CheckBox chkExportDiscard;
        private System.Windows.Forms.CheckBox chkExportOnSave;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabOpts;
        private System.Windows.Forms.CheckBox chkImportDiscard;
    }
}