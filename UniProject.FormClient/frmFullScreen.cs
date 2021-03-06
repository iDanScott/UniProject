﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniProject.FormClient
{
    public partial class frmFullScreen : Form
    {
        public frmFullScreen(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Core.WinAPI.SetForegroundWindow(this.Handle);
        }
    }
}
