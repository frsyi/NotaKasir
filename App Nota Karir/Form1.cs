﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Nota_Karir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            string help = Application.StartupPath + @"\Project Aplikasi Kasir.chm";
            Help.ShowHelp(this, help, HelpNavigator.TableOfContents);
        }
    }
}
