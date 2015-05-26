﻿using AweSimConnect.Controllers;
using AweSimConnect.Models;
using AweSimConnect.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace AweSimConnect
{
    /*
     * AweSim Connect
     *  
     * A windows native app for SSH tunneling to Ohio Supercomputer Center services.
     * 
     * Brian McMichael: bmcmichael@osc.edu
     */
    public partial class AweSimMain : Form
    {
        //AweSim Dashboard URL
        static String AWESIM_DASHBOARD_URL = "http://apps.awesim.org/devapps/";

        private PuTTYController pc;
        private VNCController vc;
        private ClipboardController cbc;
        private ClusterController clc;

        //This is here in case we use the file name for settings.
        private String fileName;

        Connection connection;

        public AweSimMain()
        {
            InitializeComponent();
        }

        // On application load
        private void AweSimMain_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.AcceptButton = bConnect;

            //Initialize controllers.
            cbc = new ClipboardController();
            clc = new ClusterController();

            connection = new Connection();

            // Adds the Clusters to the Combobox
            setupClusterBox();

            //Test network info
            vc = new VNCController(connection);
            IPGlobalProperties prop = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpi = prop.GetActiveTcpConnections();
            //label1.Text = tcpi[1].RemoteEndPoint.Address.ToString();

            label1.Text = CheckConnection("oakley.osc.edu", 8080).ToString();
            
            
            //Check to see if there is any valid data on the clipboard.
            if (cbc.CheckClipboardForAweSim())
            {
                Connection clipData = cbc.GetClipboardCluster();
                UpdateData(clipData);
            }

        }

        //TODO testing connection, move it to network tools if it works.
        private bool CheckConnection(String host, int port)
        {
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            try
            {
                socket.Connect(host, port);
                return true;
            }
            catch (SocketException ex)
            {
                if (ex.SocketErrorCode == SocketError.ConnectionRefused)
                {
                    return false;
                }
            }
            return false;
        }

        private void UpdateData(Connection newConnection)
        {
            tbUserName.Text = newConnection.UserName;
            this.connection.UserName = newConnection.UserName;
            tbRedirect.Text = newConnection.RedirectPort.ToString();
            this.connection.RedirectPort = newConnection.RedirectPort;
            tbHost.Text = newConnection.PUAServer;
            this.connection.UserName = newConnection.PUAServer;
            //Oakley for now.
            setCluster();
        }

        // Gets the file name without the extension
        // Arg 0 is always the file path.
        private string getFileName()
        {
            String file;
            String[] pathArgs = Environment.GetCommandLineArgs();
            file = System.IO.Path.GetFileNameWithoutExtension(pathArgs[0]);
            return file;
        }

        // Adds the ssh server locations to the combobox
        private void setupClusterBox()
        {
            foreach (Cluster cluster in clc.GetClusterList())
            {
                cbCluster.Items.Add(cluster);
            }
            setCluster();
        }

        // Select the first one on the list. Oakley for now.
        //TODO: Fix this
        private void setCluster()
        {
            cbCluster.SelectedIndex = 0;

        }

        // When the user modifies the host box, the variable gets set
        private void tbHost_TextChanged(object sender, EventArgs e)
        {
            this.connection.PUAServer = tbHost.Text;
        }

        // When the user modifies the redirect port box, set the variable, change label to red if not a valid integer
        private void tbRedirect_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.connection.RedirectPort = int.Parse(tbRedirect.Text);
                LabelColorChanger(lRedirect, true);
            }
            catch (Exception ex)
            {
                LabelColorChanger(lRedirect, false);
            }
        }

        //Handles the connect button action.
        private void bConnect_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(tbUserName) && Validator.IsPresent(tbPassword) && Validator.IsPresent(cbCluster) && Validator.IsPresent(tbHost) && Validator.IsInt32(tbRedirect))
            {
                pc = new PuTTYController(this.connection);
                pc.StartPlinkProcess(tbPassword.Text);
            }
        }

        //Set the username when the user enters text.
        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            this.connection.UserName = tbUserName.Text;
        }

        //Set the cluster when the user changes the box.
        private void cbCluster_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.connection.SSHHost = clc.GetClusterList()[cbCluster.SelectedIndex].Domain;
        }

        // Open a browser window to Awesim Dashboard when user clicks the logo.
        private void pbAweSimLogo_Click(object sender, EventArgs e)
        {
            Process.Start(AWESIM_DASHBOARD_URL);
        }

        private void bVNCConnect_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(tbHost) && Validator.IsInt32(tbRedirect) && Validator.IsPresent(tbVNCPassword))
            {
                vc = new VNCController(connection);
                vc.StartVNCProcess();
            }
        }

        // Checks the password field and marks the label red if the password is invalid.
        private void tbVNCPassword_TextChanged(object sender, EventArgs e)
        {
            //TODO remove
            label1.Text = CheckConnection("localhost", connection.RedirectPort).ToString();

            try
            {
                connection.VNCPassword = tbVNCPassword.Text;
                LabelColorChanger(labelVNCPassword, true);
            }
            catch (Exception ex)
            {
                LabelColorChanger(labelVNCPassword, false);
            }
        }

        //Changes the color of a label
        private void LabelColorChanger(Label label, bool valid)
        {
            label.ForeColor = valid ? Color.Black : Color.Red;
        }
    }
}
