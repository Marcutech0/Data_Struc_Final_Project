using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class AddItems : UserControl
    {
        private MySqlConnection connection;
        private const string ConnectionString = "Server=localhost;Port=3306;Database=pos;Uid=root;Password=";
        public AddItems()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            
            List<string[]> extractedData = new List<string[]>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string[] rowData = new string[dataGridView1.Columns.Count];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    rowData[i] = row.Cells[i].Value?.ToString();  
                }
                extractedData.Add(rowData);
            }

            
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                
                string insertQuery = "INSERT INTO products (productName, productCategory, productQuantity, productPrice) VALUES (@name, @category, @quantity, @price)";

                foreach (string[] rowData in extractedData)
                {
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", rowData[0]);
                        command.Parameters.AddWithValue("@category", rowData[1]);
                        command.Parameters.AddWithValue("@quantity", rowData[2]);
                        command.Parameters.AddWithValue("@price", rowData[3]);

                        command.ExecuteNonQuery();   
                    }
                }
            }

        }
    }
}
