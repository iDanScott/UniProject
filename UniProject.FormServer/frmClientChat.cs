﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniProject.Core;

namespace UniProject.FormServer
{
    public partial class frmClientChat : Form
    {
        ClientHandler client;
        public frmClientChat()
        {
            InitializeComponent();
        }

        public frmClientChat(ClientHandler handler)
        {
            InitializeComponent();
            client = handler;
        }
    }
}
