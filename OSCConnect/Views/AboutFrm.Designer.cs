﻿namespace OSCConnect.Views
{
    partial class AboutFrm
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
            this.tbLicenseArea = new System.Windows.Forms.TextBox();
            this.labelAboutTitle = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkAweSim = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLicenseArea
            // 
            this.tbLicenseArea.BackColor = System.Drawing.Color.White;
            this.tbLicenseArea.Location = new System.Drawing.Point(12, 119);
            this.tbLicenseArea.Multiline = true;
            this.tbLicenseArea.Name = "tbLicenseArea";
            this.tbLicenseArea.ReadOnly = true;
            this.tbLicenseArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLicenseArea.Size = new System.Drawing.Size(377, 119);
            this.tbLicenseArea.TabIndex = 0;
            this.tbLicenseArea.TabStop = false;
            // 
            // labelAboutTitle
            // 
            this.labelAboutTitle.AutoSize = true;
            this.labelAboutTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelAboutTitle.Location = new System.Drawing.Point(9, 79);
            this.labelAboutTitle.Name = "labelAboutTitle";
            this.labelAboutTitle.Size = new System.Drawing.Size(47, 13);
            this.labelAboutTitle.TabIndex = 1;
            this.labelAboutTitle.Text = "Connect";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Location = new System.Drawing.Point(195, 79);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(54, 13);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "[ Version ]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OSCConnect.Properties.Resources.osclogofull;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(195, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = " \t©  2015-2017 OSC";
            // 
            // linkAweSim
            // 
            this.linkAweSim.AutoSize = true;
            this.linkAweSim.BackColor = System.Drawing.Color.Transparent;
            this.linkAweSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAweSim.Location = new System.Drawing.Point(11, 99);
            this.linkAweSim.Name = "linkAweSim";
            this.linkAweSim.Size = new System.Drawing.Size(43, 12);
            this.linkAweSim.TabIndex = 5;
            this.linkAweSim.TabStop = true;
            this.linkAweSim.Text = "OSC Site";
            this.linkAweSim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAweSim_LinkClicked);
            // 
            // AboutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 250);
            this.Controls.Add(this.linkAweSim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelAboutTitle);
            this.Controls.Add(this.tbLicenseArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLicenseArea;
        private System.Windows.Forms.Label labelAboutTitle;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkAweSim;
    }
}