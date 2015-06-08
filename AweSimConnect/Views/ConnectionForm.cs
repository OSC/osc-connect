﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AweSimConnect.Models;

namespace AweSimConnect.Views
{
    public partial class ConnectionForm : Form
    {
        private Models.Connection connection;
        private string userPass;
        private ConnectionPanel panel;
        
        internal ConnectionForm(Models.Connection connection, string userPass)
        {
            InitializeComponent();
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
            panel = new ConnectionPanel(connection, userPass);
            this.Controls.Add(panel);
            this.Text = (connection.GetServerAndPort());
        }

        // Make sure that we disconnect the process in the panel when we close the form.
        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            panel.buttonDisconnect_Click(sender, e);
        }
    }
}