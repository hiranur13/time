﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            
        }
        int sayac = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
           label1.Text = DateTime.Now.ToString(@"M");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac =0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
