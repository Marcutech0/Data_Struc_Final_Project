using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using POS_FO.UserControls;
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

        double subTotal = 0;

        private void button11_Click(object sender, EventArgs e)
        {
            //dunno where to put this x'D but i'll leave it here! it shows the addItemQty winforms when u press the button
            if (dataGridView1.SelectedRows.Count > 0 )
            {
                addItemQty qty = new addItemQty();
                qty.Show();
            } else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string productName = selectedRow.Cells["productName"].Value.ToString();
                string productPrice = selectedRow.Cells["price"].Value.ToString();

              
                double conversionPrice = double.Parse(productPrice);
                double totalPrice = (conversionPrice * 0.2) + conversionPrice;

                try
                {
                    using (connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();

                        string insertQuery = "INSERT INTO sales_log (username, productName, revenue, discount) VALUES (@username, @productName, @revenue, @discount)";
                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            
                            command.Parameters.AddWithValue("@username", "usernew");
                            command.Parameters.AddWithValue("@productName", productName);
                            command.Parameters.AddWithValue("@revenue", totalPrice);
                            command.Parameters.AddWithValue("@discount", "20%");

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error accessing the database: " + ex.Message);
                }

                
                Cashier cashierForm = Application.OpenForms.OfType<Cashier>().FirstOrDefault();
                cashierForm?.AddSelectedItems(productName, "", "1", productPrice);

                double subTotal = double.Parse(cashierForm.LABEL9.Text);
                subTotal += conversionPrice;
                cashierForm.LABEL9.Text = subTotal.ToString();

                double totalPriceWithTax = (subTotal * 0.2) + subTotal;
                cashierForm.LABEL12.Text = totalPriceWithTax.ToString();
                cashierForm.LABEL11.Text = "20%";

             
                dataGridView1.ClearSelection();

                SalesLog salesLog = Application.OpenForms.OfType<SalesLog>().FirstOrDefault();
                salesLog?.putinsidesaleslog();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }
    }
}
