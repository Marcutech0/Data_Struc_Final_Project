﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_FO
{
    public partial class addItemQty : Form
    {
        public addItemQty()
        {
            InitializeComponent();
        }

        public int quantity;
        public string quantityString;
        private void button11_Click(object sender, EventArgs e)
        {
            string quantityString = textBox1.Text;
            quantity = Convert.ToInt32(quantityString);
            this.Close();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
