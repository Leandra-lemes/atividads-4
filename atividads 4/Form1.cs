﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividads_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random random = new Random();
            int[] a = new int[15];
            int[] b = new int[15];
            for (int i = 0; i < 15; i++)
            {
                a[i] = random.Next(1, 101);
                listBox1.Items.Add(a[i]);
            }
            for (int i = 0; i < 15; i++)
            {
                b[i] = a[i] * a[i];
                listBox2.Items.Add(b[i]);
            }
        }
    }
}
