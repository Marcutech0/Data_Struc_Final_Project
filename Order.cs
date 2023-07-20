using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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

                // Get the values from the selected row
                string productName = selectedRow.Cells["productName"].Value.ToString();
                string productCategory = selectedRow.Cells["category"].Value.ToString();
                string productQuantity = selectedRow.Cells["quantity"].Value.ToString();
                string productPrice = selectedRow.Cells["price"].Value.ToString();


                // Access the "Cashier" form and add the selected item
                Cashier cashierForm = Application.OpenForms.OfType<Cashier>().FirstOrDefault();
                cashierForm?.AddSelectedItems(productName, productCategory, productQuantity, productPrice);


                double conversionPrice = double.Parse(productPrice);
                subTotal += conversionPrice;

                double totalPrice = (subTotal * 0.2) + subTotal;


                Label priceString = cashierForm.LABEL9;
                priceString.Text = subTotal.ToString();

                Label taxLabel = cashierForm.LABEL11;
                taxLabel.Text = "20%";

                Label totalPriceLabel = cashierForm.LABEL12;
                totalPriceLabel.Text = totalPrice.ToString();

            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }
    }
}
