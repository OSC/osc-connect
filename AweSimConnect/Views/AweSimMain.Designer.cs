﻿namespace AweSimConnect
{
    partial class AweSimMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AweSimMain));
            this.pbAweSimLogo = new System.Windows.Forms.PictureBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.cbCluster = new System.Windows.Forms.ComboBox();
            this.lCluster = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lRemotePort = new System.Windows.Forms.Label();
            this.tbRemotePort = new System.Windows.Forms.TextBox();
            this.lRedirect = new System.Windows.Forms.Label();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.bConnect = new System.Windows.Forms.Button();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelVNCPassword = new System.Windows.Forms.Label();
            this.bVNCConnect = new System.Windows.Forms.Button();
            this.tbVNCPassword = new System.Windows.Forms.TextBox();
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.tooltips = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAweSimLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAweSimLogo
            // 
            this.pbAweSimLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbAweSimLogo.Image = global::AweSimConnect.Properties.Resources.awesimsm;
            this.pbAweSimLogo.Location = new System.Drawing.Point(30, 12);
            this.pbAweSimLogo.Name = "pbAweSimLogo";
            this.pbAweSimLogo.Size = new System.Drawing.Size(200, 84);
            this.pbAweSimLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAweSimLogo.TabIndex = 1;
            this.pbAweSimLogo.TabStop = false;
            this.tooltips.SetToolTip(this.pbAweSimLogo, "Click to visit the AweSim Dashboard.");
            this.pbAweSimLogo.Click += new System.EventHandler(this.pbAweSimLogo_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Location = new System.Drawing.Point(324, 14);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(125, 20);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Tag = "Username";
            this.tooltips.SetToolTip(this.tbUserName, "Your AweSim user name.\r\n\r\nGet yours at http://www.awesim.org");
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(324, 45);
            this.tbPassword.MaxLength = 200;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(125, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Tag = "Password";
            this.tooltips.SetToolTip(this.tbPassword, "Your AweSim password.");
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.BackColor = System.Drawing.Color.Transparent;
            this.lUsername.Location = new System.Drawing.Point(256, 16);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(58, 13);
            this.lUsername.TabIndex = 4;
            this.lUsername.Text = "Username:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.BackColor = System.Drawing.Color.Transparent;
            this.lPassword.Location = new System.Drawing.Point(258, 47);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(56, 13);
            this.lPassword.TabIndex = 5;
            this.lPassword.Text = "Password:";
            // 
            // cbCluster
            // 
            this.cbCluster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCluster.DisplayMember = "Name";
            this.cbCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCluster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCluster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCluster.FormattingEnabled = true;
            this.cbCluster.Location = new System.Drawing.Point(324, 76);
            this.cbCluster.Name = "cbCluster";
            this.cbCluster.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCluster.Size = new System.Drawing.Size(125, 23);
            this.cbCluster.TabIndex = 3;
            this.cbCluster.Tag = "Cluster";
            this.tooltips.SetToolTip(this.cbCluster, "The SSH host.\r\n\r\nDefault: oakley.osc.edu");
            this.cbCluster.ValueMember = "Name";
            this.cbCluster.SelectedIndexChanged += new System.EventHandler(this.cbCluster_SelectedIndexChanged);
            // 
            // lCluster
            // 
            this.lCluster.AutoSize = true;
            this.lCluster.BackColor = System.Drawing.Color.Transparent;
            this.lCluster.Location = new System.Drawing.Point(257, 81);
            this.lCluster.Name = "lCluster";
            this.lCluster.Size = new System.Drawing.Size(57, 13);
            this.lCluster.TabIndex = 7;
            this.lCluster.Text = "SSH Host:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lRemotePort);
            this.groupBox1.Controls.Add(this.tbRemotePort);
            this.groupBox1.Controls.Add(this.lRedirect);
            this.groupBox1.Controls.Add(this.tbLocalPort);
            this.groupBox1.Controls.Add(this.hostLabel);
            this.groupBox1.Controls.Add(this.bConnect);
            this.groupBox1.Controls.Add(this.tbHost);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lRemotePort
            // 
            this.lRemotePort.AutoSize = true;
            this.lRemotePort.Location = new System.Drawing.Point(20, 14);
            this.lRemotePort.Name = "lRemotePort";
            this.lRemotePort.Size = new System.Drawing.Size(66, 13);
            this.lRemotePort.TabIndex = 17;
            this.lRemotePort.Text = "Remote Port";
            // 
            // tbRemotePort
            // 
            this.tbRemotePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRemotePort.Location = new System.Drawing.Point(18, 30);
            this.tbRemotePort.Name = "tbRemotePort";
            this.tbRemotePort.Size = new System.Drawing.Size(68, 22);
            this.tbRemotePort.TabIndex = 4;
            this.tbRemotePort.Tag = "Remote Port";
            this.tbRemotePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooltips.SetToolTip(this.tbRemotePort, "The remote port of the resource to connect to. Ex: 5901");
            this.tbRemotePort.TextChanged += new System.EventHandler(this.tbRemotePort_TextChanged);
            // 
            // lRedirect
            // 
            this.lRedirect.AutoSize = true;
            this.lRedirect.Location = new System.Drawing.Point(265, 14);
            this.lRedirect.Name = "lRedirect";
            this.lRedirect.Size = new System.Drawing.Size(55, 13);
            this.lRedirect.TabIndex = 15;
            this.lRedirect.Text = "Local Port";
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocalPort.Location = new System.Drawing.Point(258, 30);
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.Size = new System.Drawing.Size(66, 22);
            this.tbLocalPort.TabIndex = 6;
            this.tbLocalPort.Tag = "Local Port";
            this.tbLocalPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooltips.SetToolTip(this.tbLocalPort, "The port to map to your local machine. \r\n\r\nExample: 5901 for VNC or 8080 for brow" +
        "ser tunneling.");
            this.tbLocalPort.TextChanged += new System.EventHandler(this.tbRedirect_TextChanged);
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(153, 14);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(29, 13);
            this.hostLabel.TabIndex = 12;
            this.hostLabel.Tag = "Host";
            this.hostLabel.Text = "Host";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(348, 19);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(89, 34);
            this.bConnect.TabIndex = 7;
            this.bConnect.Text = "Connect";
            this.tooltips.SetToolTip(this.bConnect, "Enter your connection information and click this to establish a secure connection" +
        " to AweSim.");
            this.bConnect.UseVisualStyleBackColor = false;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // tbHost
            // 
            this.tbHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHost.Location = new System.Drawing.Point(92, 30);
            this.tbHost.MaxLength = 300;
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(160, 22);
            this.tbHost.TabIndex = 5;
            this.tbHost.Tag = "Host";
            this.tbHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooltips.SetToolTip(this.tbHost, "The host name of your requested node. Get this from the AweSim Dashboard.\r\n\r\nEx: " +
        "n231.ten.osc.edu");
            this.tbHost.TextChanged += new System.EventHandler(this.tbHost_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.labelVNCPassword);
            this.groupBox2.Controls.Add(this.bVNCConnect);
            this.groupBox2.Controls.Add(this.tbVNCPassword);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 62);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // labelVNCPassword
            // 
            this.labelVNCPassword.AutoSize = true;
            this.labelVNCPassword.Location = new System.Drawing.Point(130, 15);
            this.labelVNCPassword.Name = "labelVNCPassword";
            this.labelVNCPassword.Size = new System.Drawing.Size(78, 13);
            this.labelVNCPassword.TabIndex = 12;
            this.labelVNCPassword.Tag = "Host";
            this.labelVNCPassword.Text = "VNC Password";
            // 
            // bVNCConnect
            // 
            this.bVNCConnect.Location = new System.Drawing.Point(348, 19);
            this.bVNCConnect.Name = "bVNCConnect";
            this.bVNCConnect.Size = new System.Drawing.Size(89, 34);
            this.bVNCConnect.TabIndex = 9;
            this.bVNCConnect.Text = "Launch VNC";
            this.tooltips.SetToolTip(this.bVNCConnect, "Click to launch a VNC Connection");
            this.bVNCConnect.UseVisualStyleBackColor = false;
            this.bVNCConnect.Click += new System.EventHandler(this.bVNCConnect_Click);
            // 
            // tbVNCPassword
            // 
            this.tbVNCPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVNCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVNCPassword.Location = new System.Drawing.Point(92, 31);
            this.tbVNCPassword.MaxLength = 300;
            this.tbVNCPassword.Name = "tbVNCPassword";
            this.tbVNCPassword.Size = new System.Drawing.Size(160, 22);
            this.tbVNCPassword.TabIndex = 8;
            this.tbVNCPassword.Tag = "VNC Password";
            this.tbVNCPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooltips.SetToolTip(this.tbVNCPassword, "The 8 character password associated with your node.");
            this.tbVNCPassword.TextChanged += new System.EventHandler(this.tbVNCPassword_TextChanged);
            // 
            // timerConnection
            // 
            this.timerConnection.Interval = 1000;
            this.timerConnection.Tag = "timer";
            this.timerConnection.Tick += new System.EventHandler(this.timerConnection_Tick);
            // 
            // tooltips
            // 
            this.tooltips.AutoPopDelay = 5000;
            this.tooltips.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tooltips.InitialDelay = 2000;
            this.tooltips.IsBalloon = true;
            this.tooltips.ReshowDelay = 100;
            // 
            // AweSimMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::AweSimConnect.Properties.Resources.header;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lCluster);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.cbCluster);
            this.Controls.Add(this.pbAweSimLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AweSimMain";
            this.Text = "AweSim Connect";
            this.Load += new System.EventHandler(this.AweSimMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAweSimLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAweSimLogo;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.ComboBox cbCluster;
        private System.Windows.Forms.Label lCluster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.Label lRedirect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelVNCPassword;
        private System.Windows.Forms.Button bVNCConnect;
        private System.Windows.Forms.TextBox tbVNCPassword;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Timer timerConnection;
        private System.Windows.Forms.Label lRemotePort;
        private System.Windows.Forms.TextBox tbRemotePort;
        private System.Windows.Forms.ToolTip tooltips;

    }
}
