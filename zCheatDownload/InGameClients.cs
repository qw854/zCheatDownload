﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zCheatDownload
{
    public partial class InGameClients : Form
    {
        public InGameClients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new InGameClients1_8_9().ShowDialog ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new InGameClients_1_16_5().ShowDialog ();
        }
    }
}
