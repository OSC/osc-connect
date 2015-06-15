﻿using System;
using AweSimConnect.Properties;

namespace AweSimConnect.Models
{
    class AdvancedSettings
    {
        internal static readonly bool DEMO_MODE = true;
        
        public void SaveUsername(string userName)
        {
            Settings.Default.Username = userName;
            Settings.Default.Save();
        }

        public string GetUsername()
        {
            string name = "";
            try
            {
                name = Settings.Default.Username;
            }
            catch (Exception)
            {
                
            }
            return name;
        }

        public void RememberUser(bool remember)
        {
            Settings.Default.IsPassSaved = remember;
            Settings.Default.Save();
        }

        public bool IsUserSaved()
        {
            return Settings.Default.IsPassSaved;
        }

        // Encrypts the password and saves to settings
        public void SavePassword(string password)
        {
            Settings.Default.Userpass = PasswordEncryption.Encrypt(password);
            Settings.Default.Save();
        }

        // Returns the decrypted user password from the settings
        internal string GetPassword()
        {
            try
            {
                return PasswordEncryption.Decrypt(Settings.Default.Userpass);
            }
            catch (Exception)
            {
                return "";
            }
        }

        public void SaveSSHHostCode(OSCCluster cluster)
        {
            Settings.Default.SSHHost = cluster.Code;
            Settings.Default.Save();
        }

        public string GetSSHHostCode()
        {
            return Settings.Default.SSHHost;
        }
    }
}
