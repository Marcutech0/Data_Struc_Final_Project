using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace POS_FO
{
    public partial class EmployeeKey : Form
    {

        private MySqlConnection connection;
        private const string ConnectionString = "Server=localhost;Port=3306;Database=pos;Uid=root;Password=";


        public static string GetXamppControlPath()
        {
            //hi 
            string currentDirectory = Directory.GetCurrentDirectory();
            string xamppRelativePath = "XAMPP";  // Adjust the relative path
            string xamppControlPath = Path.Combine(currentDirectory, xamppRelativePath, "xampp-control.exe");
            return xamppControlPath;
        }

        public static void StartMySQLServer()
        {
            string xamppControlPath = GetXamppControlPath();

            // Check if XAMPP Control Panel is already running
            Process[] runningProcesses = Process.GetProcessesByName("xampp-control");
            if (runningProcesses.Length > 0)
            {
                // XAMPP Control Panel is already running, no need to start it again
                return;
            }

            // Start the XAMPP Control Panel
            Process process = new Process();
            process.StartInfo.FileName = xamppControlPath;
            process.StartInfo.Arguments = "start mysql";
            process.Start();
        }
        public EmployeeKey()
        {
            StartMySQLServer();
            InitializeComponent();
            connection = new MySqlConnection(ConnectionString);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            cashier.Show();
            this.Hide();
        }

        private void EmployeeKey_Load(object sender, EventArgs e)
        {

        }

        private void EKEnter_Click(object sender, EventArgs e)
        {

            string username = userTxt.Text;
            string password = passTxt.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }
            else
            {

                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE username = @username AND password = @password", connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                switch (count)
                {
                    case > 0:
                        MessageBox.Show("Logging in now");
                        Cashier cashier = new Cashier();
                        cashier.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Invalid username or password.");
                        connection.Close();
                        break;
                }
            }

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SUButton_Click(object sender, EventArgs e)
        {


            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//hahaha
