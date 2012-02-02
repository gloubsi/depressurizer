﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Depressurizer {
    public partial class ProfileDlg : Form {
        public ProfileData Profile;

        public bool DownloadOnCreate {
            get {
                return chkActDownload.Checked;
            }
        }

        public bool ImportOnCreate {
            get {
                return chkActImport.Checked;
            }
        }

        public ProfileDlg() {
            InitializeComponent();
        }

        #region Event Handlers

        private void ProfileDlg_Load( object sender, EventArgs e ) {
            txtFilePath.Text = System.Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData ) + @"\Depressurizer\Default.profile";
            RefreshIdList();
        }

        private void cmdBrowse_Click( object sender, EventArgs e ) {
            SaveFileDialog dlg = new SaveFileDialog();

            try {
                FileInfo f = new FileInfo( txtFilePath.Text );
                dlg.InitialDirectory = f.DirectoryName;
                dlg.FileName = f.Name;
            } catch( ArgumentException ) {
            }

            dlg.DefaultExt = "profile";
            dlg.AddExtension = true;
            dlg.Filter = "Profiles (*.profile)|*.profile";
            DialogResult res = dlg.ShowDialog();
            if( res == System.Windows.Forms.DialogResult.OK ) {
                txtFilePath.Text = dlg.FileName;
            }
        }

        private void cmdCancel_Click( object sender, EventArgs e ) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cmdOk_Click( object sender, EventArgs e ) {
            if( CreateProfile() ) {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        #endregion

        private bool CreateProfile() {
            FileInfo file;
            try {
                file = new FileInfo( txtFilePath.Text );
            } catch {
                MessageBox.Show( "You must enter a valid profile file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }

            if( !file.Directory.Exists ) {
                try {
                    file.Directory.Create();
                } catch {
                    MessageBox.Show( "Failed to create parent directory of profile file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return false;
                }
            }

            ProfileData profile = new ProfileData();
            profile.AccountID = cmbAccountID.Text;
            profile.CommunityName = txtCommunityName.Text;
            profile.AutoDownload = chkAutoDownload.Checked;
            profile.AutoExport = chkAutoExport.Checked;
            profile.AutoImport = chkAutoImport.Checked;
            profile.ExportDiscard = chkExportDiscard.Checked;
            try {
                profile.Save( file.FullName );
            } catch( ApplicationException e ) {
                MessageBox.Show( e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }

            this.Profile = profile;
            return true;
        }

        /// <summary>
        /// Populates the combo box with all located account IDs
        /// </summary>
        private void RefreshIdList() {
            cmbAccountID.BeginUpdate();
            cmbAccountID.Items.Clear();
            cmbAccountID.ResetText();
            cmbAccountID.Items.AddRange( GetSteamIds() );
            if( cmbAccountID.Items.Count > 0 ) {
                cmbAccountID.SelectedIndex = 0;
            }
            cmbAccountID.EndUpdate();
        }

        /// <summary>
        /// Gets a list of located account ids. Uses settings for the steam path.
        /// </summary>
        /// <returns>An array of located IDs</returns>
        private string[] GetSteamIds() {
            try {
                DirectoryInfo dir = new DirectoryInfo( DepSettings.Instance().SteamPath + "\\userdata" );
                if( dir.Exists ) {
                    DirectoryInfo[] userDirs = dir.GetDirectories();
                    string[] result = new string[userDirs.Length];
                    for( int i = 0; i < userDirs.Length; i++ ) {
                        result[i] = userDirs[i].Name;
                    }
                    return result;
                }
                return new string[0];
            } catch {
                return new string[0];
            }
        }
    }
}