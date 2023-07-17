using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_FO.UserControls
{
    public partial class Stocks : UserControl
    {
        private MySqlConnection connection;
        private const string ConnectionString = "Server=localhost;Port=3306;Database=pos;Uid=root;Password=";
        public Stocks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            dairy.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                // Clear the existing rows in the DataGridView
                dataGridView1.Rows.Clear();

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string searchQuery = "SELECT * FROM products WHERE productName LIKE @keyword OR productCategory LIKE @keyword";
                    using (MySqlCommand command = new MySqlCommand(searchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@keyword", "%" + searchKeyword + "%");

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productName = reader.GetString("productName");
                                string productCategory = reader.GetString("productCategory");
                                string productQuantity = reader.GetString("productQuantity");
                                string productPrice = reader.GetString("productPrice");

                                // Add a new row to the DataGridView
                                dataGridView1.Rows.Add(productName, productCategory, productQuantity, productPrice);
                            }
                        }
                    }
                }
            }
            else
            {
                // Clear the existing rows in the DataGridView
                dataGridView1.Rows.Clear();
            }
        }

        private void Stocks_Load(object sender, EventArgs e)
        {

        }
    }
}