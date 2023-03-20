﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Metroid_Launcher
{
    public partial class progressForm : Form
    {
        public progressForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.updateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(12, 27);
            this.progBar.Maximum = 999999;
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(500, 25);
            this.progBar.TabIndex = 0;
            this.progBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // updateLabel
            // 
            this.updateLabel.Location = new System.Drawing.Point(12, 9);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(500, 15);
            this.updateLabel.TabIndex = 1;
            this.updateLabel.Text = "Update Status";
            this.updateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressForm
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1191, 806);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.progBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "progressForm";
            this.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
