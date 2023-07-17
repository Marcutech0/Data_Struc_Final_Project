using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
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
    public partial class Order : Form
    {

        private MySqlConnection connection;
        private const string ConnectionString = "Server=localhost;Port=3306;Database=pos;Uid=root;Password=";

        public Order()
        {
            connection = new MySqlConnection(ConnectionString);
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FilterAndDisplayProducts("Dairy");
        }
        private void FilterAndDisplayProducts(string category)
        {
            // Clear the existing rows in the DataGridView
            dataGridView1.Rows.Clear();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM products WHERE productCategory = @category";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@category", category);

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

        private void button15_Click(object sender, EventArgs e)
        {
            FilterAndDisplayProducts("Meal");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FilterAndDisplayProducts("Drink");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FilterAndDisplayProducts("Snack");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FilterAndDisplayProducts("Fruit");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FilterAndDisplayProducts("Vegetable");
        }
    }
}
