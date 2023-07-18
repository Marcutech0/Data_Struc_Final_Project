﻿using System;
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
using static System.Net.Mime.MediaTypeNames;

namespace POS_FO
{
    public partial class Cashier : Form
    {
        private Discount? discount;
        private MySqlConnection connection;
        private const string ConnectionString = "Server=localhost;Port=3306;Database=pos;Uid=root;Password=";

        public void AddItemToCart(string productName, string productQuantity, string productPrice)
        {
            string selectQuery = "SELECT * FROM products WHERE productName = @productName";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@productName", productName);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string retrievedProductName = reader.GetString("productName");
                        string retrievedProductQuantity = reader.GetString("quantity");
                        string retrievedProductPrice = reader.GetString("price");

                        // Add the retrieved product details to the DataGridView in the "Cashier" form
                        selectedItemsGridView.Rows.Add(retrievedProductName, retrievedProductQuantity, retrievedProductPrice);
                    }
                }
            }
        }
        public void UpdateSelectedItems(string productName, string productQuantity, string productPrice)
        {
            selectedItemsGridView.Rows.Add(productName, productQuantity, productPrice);
        }
        public void AddSelectedItems(string productName, string productQuantity, string productPrice)
        {
            selectedItemsGridView.Rows.Add(productName, productQuantity, productPrice);
        }
        public void cashPayment()
        {
            double subTotalAmount, totalAmount, change;
            double tax = 0.2;

            double paymentValue = double.Parse(label2.Text);

            // totalAmount = subTotalAmount + (tax * subTotalAmount);
            // change = paymentValue - totalAmount;
        }

        public void cardPayment()
        {

        }

        public void mobilewalletPayment()
        {

        }
        public Cashier()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            categories1.Visible = false;
            coupon1.Visible = false;
            helpPage1.Visible = false;
            salesLog1.Visible = false;
            addItems1.Visible = false;
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {

        }

        private void couponButton_Click(object sender, EventArgs e)
        {
            categories1.Visible = false;
            coupon1.Visible = true;
            helpPage1.Visible = false;
            salesLog1.Visible = false;
            addItems1.Visible = false;
        }

        private void salesLogButton_Click(object sender, EventArgs e)
        {
            categories1.Visible = false;
            coupon1.Visible = false;
            helpPage1.Visible = false;
            salesLog1.Visible = true;
            addItems1.Visible = false;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            categories1.Visible = false;
            coupon1.Visible = false;
            helpPage1.Visible = true;
            salesLog1.Visible = false;
            addItems1.Visible = false;
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
            Stocks stock = new Stocks();
            addUserControl(stock);

        }

        private void salesLogButton2_Click(object sender, EventArgs e)
        {
            SalesLog salesLog = new SalesLog();
            addUserControl(salesLog);
        }

        private void addItemButton_Click_1(object sender, EventArgs e)
        {
            AddItems add_items = new AddItems();
            addUserControl(add_items);

        }

        private void addUserControl(UserControl userControl)
        {
            ucPanel.Controls.Clear();
            ucPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void discountButton_Click_1(object sender, EventArgs e)
        {
            discount = new Discount();
            discount.FormClosed += Discount_FormClosed;
            discount.Show();

            discountButton.Enabled = false;
        }

        private void Discount_FormClosed(object? sender, FormClosedEventArgs e)
        {
            discountButton.Enabled = true;
        }

        private void Cashier_Load_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            string comboBoxOption = comboBox1.SelectedItem.ToString();

            switch (comboBoxOption)
            {
                case "Credit/Debit Card":
                    break;
                case "Cash":
                    break;
                case "Mobile Wallet":
                    break;
            }

        }

        /*do this tmr
         * make new button for after inputting the numbers auto search
         * constructor for the button click event
         * i cant see anything :-(
         */
        private void findproduact(string productId)
        {
            string query = "SELECT * FROM products WHERE productID = @productId";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@productId", productId);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string productName = reader.GetString(1);
                    string productPrice = reader.GetString(2);
                    MessageBox.Show( productId + productName + productPrice);
                }
                else
                {
                    MessageBox.Show("Pee");
                }
                reader.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //grafewjfoia
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void salesLogButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void selectedItemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
