﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circunferencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        circulo c = new circulo();
        private void Button1_Click(object sender, EventArgs e)
        {
            c.Raio = textBox1.Text;
            if (radioButton1.Checked) label4.Text = c.Area;
            else if (radioButton2.Checked) label4.Text = c.Perimetro;
            else if (radioButton3.Checked) label4.Text = c.Diagonal;
        }
    }
}
