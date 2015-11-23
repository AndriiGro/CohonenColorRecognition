﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CohonenSOM.Services;
using MetroFramework.Forms;

namespace CohonenSOM
{
    public partial class Main : MetroForm
    {
        private readonly FileService _fileService = new FileService();
        public Main()
        {
            InitializeComponent();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileService.SaveBitmapFileToNetworkParameters();
        }
    }
}
