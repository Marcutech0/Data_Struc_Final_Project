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

namespace POS_FO
{
    public partial class Signup : Form
    {
        private MySqlConnection connection;
        private const string ConnectionString = "Server=localhost;Port=3306;Database=pos;Uid=root;Password=";

        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
        }

        private void EKEnter_Click(object sender, EventArgs e)
        {
            string username = newUserTxt.Text;
            string password = newPassTxt.Text;
            using (var connection = new MySqlConnection(ConnectionString))
            {
                string sqlQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
                using (var command = new MySqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@username", newUserTxt.Text);
                        command.Parameters.AddWithValue("@password", newPassTxt.Text);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sign up successful!");
                            EmployeeKey key = new EmployeeKey();
                            key.Show();
                            this.Hide();
                        }
                        else
                        {
                            Console.WriteLine("Data insertion failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeKey key = new EmployeeKey();
            key.Show();
            this.Hide();
        }
    }
}