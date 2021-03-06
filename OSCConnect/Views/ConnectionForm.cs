﻿using System;
using System.Windows.Forms;
using OSCConnect.Models;

namespace OSCConnect.Views
{
    public partial class ConnectionForm : Form
    {
        private Models.Connection connection;
        private string userPass;
        private ConnectionPanel panel;
        
        internal ConnectionForm(Connection connection, string userPass)
        {
            InitializeComponent();
            this.Icon = OSCConnect.Properties.Resources.oscicontransparent;
            this.connection = connection;
            this.userPass = userPass;
        }

        internal Connection GetConnection()
        {
            return connection;
        }


        // Form load.
        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            panel = new ConnectionPanel(connection, userPass, this);
            this.Controls.Add(panel);
            this.Text = (connection.GetServerAndPort());
            
        }
        
        // Make sure that we disconnect the process in the panel when we close the form.
        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.Parent_Form = new ConnectionForm(connection, userPass);
            panel.buttonDisconnect_Click(sender, e);
        }
    }
}
