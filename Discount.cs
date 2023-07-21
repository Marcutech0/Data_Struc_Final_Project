using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_FO
{
    public partial class Discount : Form
    {
        private string _productPrice;
        private DataGridView _selectedItemsGridView;
        private MySqlConnection connection;
        private const string ConnectionString = "Server=localhost;Port=3306;Database=pos;Uid=root;Password=";

        public Discount(string productPrice, DataGridView selectedItemsGridView)
        {
            this._productPrice = productPrice;
            this._selectedItemsGridView = selectedItemsGridView;

            InitializeComponent();
            LoadFormValues();
        }
        public void LoadFormValues()
        {
            textBox1.Text = this._productPrice;

        }


        private void Discount_Load(object sender, EventArgs e)
        {

            LoadFormValues();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            discountmaker();

        }


        private void discountmaker()
        {
            //if (decimal.TryParse(textBox3.text, out decimal) why it dont work?

            if (decimal.TryParse(textBox2.Text, out decimal discountPercentage) &&
                decimal.TryParse(_productPrice, out decimal productPrice))
            {
                decimal discountedPrice = productPrice - (productPrice * (discountPercentage / 100));
                textBox3.Text = discountedPrice.ToString("0.00");
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox3.Text, out decimal discountedPrice))
            {
                if (_selectedItemsGridView.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = _selectedItemsGridView.SelectedRows[0];
                    row.Cells["price"].Value = discountedPrice.ToString("0.00");

          
                    string productName = row.Cells["productName"].Value.ToString();
                    string username = "usernew"; 

                    try
                    {
                        using (connection = new MySqlConnection(ConnectionString))
                        {
                            connection.Open();

                            string insertQuery = "INSERT INTO sales_log (username, productName, revenue, discount) VALUES (@username, @productName, @revenue, @discount)";
                            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@username", username);
                                command.Parameters.AddWithValue("@productName", productName);
                                command.Parameters.AddWithValue("@revenue", discountedPrice); 
                                command.Parameters.AddWithValue("@discount", decimal.Parse(textBox2.Text));

                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            this.Close();
        }




        //-----------------------------
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }
    }
}