﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lmvzLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = System.Drawing.Bitmap.FromFile(@"\changeLocAct.jpg");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = System.Drawing.Bitmap.FromFile(@"\changeLocNoAct.jpg");
        }
       
    }
}
