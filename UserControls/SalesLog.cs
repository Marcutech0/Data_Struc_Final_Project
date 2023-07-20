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

namespace POS_FO.UserControls
{
    public partial class SalesLog : UserControl
    {
        private MySqlConnection connection;
        private const string ConnectionString = "Server=localhost;Port=3306;Database=pos;Uid=root;Password=";

        public SalesLog()
        {
            InitializeComponent();
        }


        private void SalesLog_Load(object sender, EventArgs e)
        {
           
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Username";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Revenue";
            dataGridView1.Columns[3].Name = "Discount";

            putinsidesaleslog();
        }

        public void putinsidesaleslog()
        {
            try
            {
                using (connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT username, productName, revenue, discount FROM sales_log";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.Rows.Clear();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                
                                dataGridView1.Rows.Add(row["username"], row["productName"], row["revenue"], row["discount"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
