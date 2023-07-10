using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using POS_FO.UserControls;

namespace POS_FO
{ 
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            categories1.Visible = true;
            coupon1.Visible = false;
            helpPage1.Visible = false;
            salesLog1.Visible = false;
            addItems1.Visible = false;
            paymentPage1.Visible = false;
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            categories1.Visible = true;
            coupon1.Visible = false;
            helpPage1.Visible = false;
            salesLog1.Visible = false;
            addItems1.Visible = false;
            paymentPage1.Visible = false;
        }

        private void couponButton_Click(object sender, EventArgs e)
        {
            categories1.Visible = false;
            coupon1.Visible = true;
            helpPage1.Visible = false;
            salesLog1.Visible = false;
            addItems1.Visible = false;
            paymentPage1.Visible = false;
        }

        private void salesLogButton_Click(object sender, EventArgs e)
        {
            categories1.Visible = false;
            coupon1.Visible = false;
            helpPage1.Visible = false;
            salesLog1.Visible = true;
            addItems1.Visible = false;
            paymentPage1.Visible = false;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            categories1.Visible = false;
            coupon1.Visible = false;
            helpPage1.Visible = false;
            salesLog1.Visible = false;
            addItems1.Visible = true;
            paymentPage1.Visible = false;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            categories1.Visible = false;
            coupon1.Visible = false;
            helpPage1.Visible = true;
            salesLog1.Visible = false;
            addItems1.Visible = false;
            paymentPage1.Visible = false;
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            categories1.Visible = false;
            coupon1.Visible = false;
            helpPage1.Visible = false;
            salesLog1.Visible = false;
            addItems1.Visible = false;
            paymentPage1.Visible = true;
        }

        private void paymentPage1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "1";

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "0";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoriesButton_Click_1(object sender, EventArgs e)
        {
            paymentPage1.Controls.Clear();
            Categories categories = new Categories();
            paymentPage1.Controls.Add(categories);

        }
    }
}
