﻿using System;
using System.Windows.Forms;
using OSCConnect.Controllers;
using OSCConnect.Models;

namespace OSCConnect.Views
{
    public partial class AdvSettingsFrm : Form
    {
        //TODO Come up with more advanced settings.

        private string CLIENT_VERSION = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        private AdvancedSettings _settings;
        private OSCClusterController _clusterController;
        private bool _settingsChanged;

        public AdvSettingsFrm()
        {
            InitializeComponent();
            this.Icon = OSCConnect.Properties.Resources.oscicontransparent;
            _settings = new AdvancedSettings();
            _clusterController = new OSCClusterController();

            //TODO move the combobox setup to it's own method
            string presetClusterCode = _settings.GetSSHHostCode();
            int clusterSelected = 0;
            for (int i = 0; i < _clusterController.GetClusterList().Count; i++)
            {
                OSCCluster c = _clusterController.GetClusterAtIndex(i);
                cbHosts.Items.Add(c);
                if (c.Code.Equals(presetClusterCode))
                {
                    clusterSelected = i;
                }
            }
            cbHosts.SelectedIndex = clusterSelected;
            cbClipboardDetect.Checked = _settings.DetectClipboard();
            cbLaunchTunnel.Checked = _settings.LaunchTunnelAutomatically();
            cbNewVersionCheck.Checked = _settings.AutoCheckNewVersion();
            tbVNCQuality.Value = _settings.GetVNCQuality();
            labelQualityValue.Text = _settings.GetVNCQuality().ToString();
        }

        private void AdvSettingsFrm_Load(object sender, EventArgs e)
        {
            labelVersion.Text = CLIENT_VERSION;
            cbSaveUser.Checked = _settings.IsUserSaved();
        }

        private void cbSaveUser_CheckedChanged(object sender, EventArgs e)
        {
            _settingsChanged = true;
            _settings.RememberUser(cbSaveUser.Checked);
        }

        public bool AdvancedSettingsChanged()
        {
            if (_settingsChanged)
            {
                _settingsChanged = false;
                return true;
            }
            return false;
        }

        private void cbHosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settingsChanged = true;
            _settings.SaveSSHHostCode(_clusterController.GetClusterList()[cbHosts.SelectedIndex]);
        }

        private void cbClipboardDetect_CheckedChanged(object sender, EventArgs e)
        {
            _settings.SetDetectClipboard(cbClipboardDetect.Checked);
        }
        
        private void cbLaunchTunnel_CheckedChanged(object sender, EventArgs e)
        {
            _settings.SetLaunchSSHTunnelAutomatically(cbLaunchTunnel.Checked);
        }

        private void cbNewVersionCheck_CheckedChanged(object sender, EventArgs e)
        {
            _settings.SetAutoCheckNewVersion(cbNewVersionCheck.Checked);
        }

        private void tbVNCQuality_Scroll(object sender, EventArgs e)
        {
            _settings.SetVNCQuality(tbVNCQuality.Value);
            labelQualityValue.Text = tbVNCQuality.Value.ToString();
        }
    }
}
