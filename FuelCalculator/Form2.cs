﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelCalculator
{
    public partial class Form2 : Form
    {
        public string gr;
        public double dis;

        private Form1 _form1;

        
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gr = comboBox1.Text;
            dis = double.Parse(textBox2.Text);
            _form1.retFromF2();
            this.Close();
        }
    }
}